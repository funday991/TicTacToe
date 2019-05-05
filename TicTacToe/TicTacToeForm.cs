using System;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        /* PROPERTIES */
        #region Properties

        // Static properties
        private static Random random = new Random();

        // Complex properties

        private string _XPlayerName = "";
        string XPlayerName
        {
            get { return _XPlayerName; }

            set
            {
                if (value != _XPlayerName) ResetCounters();
                _XPlayerName = value;
            }
        }

        private string _OPlayerName = "";
        string OPlayerName
        {
            get { return _OPlayerName; }

            set
            {
                if (value != _OPlayerName) ResetCounters();
                _OPlayerName = value;
            }
        }

        // Stored properties

        private bool isOnePlayerMode;
        private bool xRoleIsSelected = true;
        private bool isXTurn;
        private int turnCount;

        // Convenience getters

        private string CurrentTurnButtonLabel
        {
            get { return isXTurn ? "X" : "O"; }
        }

        private bool FoundHorizontalWin
        {
            get
            {
                return
                    (!A1.Enabled && A1.Text == A2.Text && A2.Text == A3.Text) ||
                    (!B1.Enabled && B1.Text == B2.Text && B2.Text == B3.Text) ||
                    (!C1.Enabled && C1.Text == C2.Text && C2.Text == C3.Text);
            }
        }

        private bool FoundVerticalWin
        {
            get
            {
                return
                (!A1.Enabled && A1.Text == B1.Text && B1.Text == C1.Text) ||
                (!A2.Enabled && A2.Text == B2.Text && B2.Text == C2.Text) ||
                (!A3.Enabled && A3.Text == B3.Text && B3.Text == C3.Text);
            }
        }

        private bool FoundDiagonalWin
        {
            get
            {
                return
                (!A1.Enabled && A1.Text == B2.Text && B2.Text == C3.Text) ||
                (!A3.Enabled && A3.Text == B2.Text && B2.Text == C1.Text);
            }
        }

        #endregion


        /* LIFECYCLE */
        #region Lifecycle

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        #endregion


        /* EVENT HANDLERS */
        #region Event Handlers

        // Menu strips click handlers

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void ResetCountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetCounters();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tic tac toe button events

        private void TicTacToeButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            button.Text = CurrentTurnButtonLabel;
            button.Enabled = false;

            turnCount++;

            CheckForWinner();

            isXTurn = !isXTurn;

            if (xRoleIsSelected && !isXTurn) PerformComputerMove(false);
            else if (!xRoleIsSelected && isXTurn) PerformComputerMove(true);
        }

        private void TicTacToeButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = CurrentTurnButtonLabel;
        }

        private void TicTacToeButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Enabled) button.Text = "";
        }

        #endregion


        /* PUBLIC METHODS */
        #region Public Methods
       
        public void SetPlayerNames(string nameX, string nameO)
        {
            XPlayerName = nameX == String.Empty ? "Игрок Х" : nameX;
            OPlayerName = nameO == String.Empty ? "Игрок O" : nameO;
        }

        public void SetOnePlayerModeTo(bool isChecked)
        {
            isOnePlayerMode = isChecked;
        }

        public void SetRoleToX(bool xRoleIsSelected)
        {
            this.xRoleIsSelected = xRoleIsSelected;
        }

        #endregion


        /* PRIVATE METHODS */
        #region Private Methods

        // Main methods
        private void StartNewGame()
        {
            PresentNamePicker();

            xPlayerLabel.Text = XPlayerName;
            oPlayerLabel.Text = OPlayerName;

            isXTurn = true;
            turnCount = 0;

            ToggleButtons(true);

            if (isOnePlayerMode && !xRoleIsSelected) PerformComputerMove(true);
        }

        private void PresentNamePicker()
        {
            PlayerNamesForm playerNamesForm = new PlayerNamesForm
            {
                gameForm = this,
                XPlayerName = XPlayerName == "Игрок Х" ? "" : XPlayerName,
                OPlayerName = OPlayerName == "Игрок O" ? "" : OPlayerName,
            };

            playerNamesForm.SetupCheckBoxWithCheckedState(isOnePlayerMode, xRoleIsSelected);

            playerNamesForm.ShowDialog();
        }

        private void ResetCounters()
        {
            xWinCountLabel.Text = "0";
            oWinCountLabel.Text = "0";
            drawCountLabel.Text = "0";
        }

        private void CheckForWinner()
        {
            bool winnerFound = FoundHorizontalWin || FoundVerticalWin || FoundDiagonalWin;

            if (winnerFound)
            {
                ToggleButtons(false);

                string winner = CurrentTurnButtonLabel;

                switch (winner)
                {
                    case "X":
                        xWinCountLabel.Text = IncrementCount(xWinCountLabel);
                        break;
                    case "O":
                        oWinCountLabel.Text = IncrementCount(oWinCountLabel);
                        break;
                    default:
                        break;
                }

                MessageBox.Show(string.Format("\"{0}\" победили!", winner), "Ура!");
            }
            else if (turnCount == 9)
            {
                drawCountLabel.Text = IncrementCount(drawCountLabel);

                MessageBox.Show("Ничья!", "Хм-м...");
            }
        }

        private void ToggleButtons(bool isEnabled)
        {
            foreach (Control control in Controls)
            {
                try
                {
                    Button button = (Button)control;
                    button.Text = isEnabled ? "" : button.Text;
                    button.Enabled = isEnabled;
                }
                catch { }
            }
        }

        // Computer logic methods

        private void PerformComputerMove(bool computerIsX)
        {
            Button moveButton = null;

            if (turnCount == 0) moveButton = RandomMove();

            if (moveButton == null)
            {
                moveButton = LookForWinOrBlock(computerIsX ? "X" : "O");
                if (moveButton == null)
                {
                    moveButton = LookForWinOrBlock(computerIsX ? "O" : "X");
                    if (moveButton == null)
                    {
                        moveButton = LookForCorner(computerIsX ? "X" : "O");
                        if (moveButton == null)
                        {
                            moveButton = LookForOpenSpace();
                        }
                    }
                }
            }
            
            if (moveButton != null) moveButton.PerformClick();
        }

        private Button LookForOpenSpace()
        {
            Button button = null;

            foreach (Control control in Controls)
            {
                button = control as Button;

                if (button != null && button.Enabled) return button;
            }

            return null;
        }

        private Button LookForCorner(string sign)
        {
            if (A1.Text == sign)
            {
                if (A3.Enabled) return A3;
                if (C3.Enabled) return C3;
                if (C1.Enabled) return C1;
            }

            if (A3.Text == sign)
            {
                if (A1.Enabled) return A1;
                if (C3.Enabled) return C3;
                if (C1.Enabled) return C1;
            }

            if (C3.Text == sign)
            {
                if (A1.Enabled) return A1;
                if (A3.Enabled) return A3;
                if (C1.Enabled) return C1;
            }

            if (C1.Text == sign)
            {
                if (A1.Enabled) return A1;
                if (A3.Enabled) return A3;
                if (C3.Enabled) return C3;
            }

            return null;
        }

        private Button LookForWinOrBlock(string sign)
        {
            Button horizontalMove = HorizontalComputerMove(sign);
            if (horizontalMove == null)
            {
                Button verticalMove = VerticalComputerMove(sign);
                if (verticalMove == null)
                {
                    return DiagonalComputerMove(sign);
                }
                else return verticalMove;
            }
            else return horizontalMove;
        }

        private Button HorizontalComputerMove(string sign)
        {
            if (A1.Text == sign && A2.Text == sign && A3.Enabled) return A3;
            if (A2.Text == sign && A3.Text == sign && A1.Enabled) return A1;
            if (A1.Text == sign && A3.Text == sign && A2.Enabled) return A2;

            if (B1.Text == sign && B2.Text == sign && B3.Enabled) return B3;
            if (B2.Text == sign && B3.Text == sign && B1.Enabled) return B1;
            if (B1.Text == sign && B3.Text == sign && B2.Enabled) return B2;

            if (C1.Text == sign && C2.Text == sign && C3.Enabled) return C3;
            if (C2.Text == sign && C3.Text == sign && C1.Enabled) return C1;
            if (C1.Text == sign && C3.Text == sign && C2.Enabled) return C2;

            return null;
        }

        private Button VerticalComputerMove(string sign)
        {
            if (A1.Text == sign && B1.Text == sign && C1.Enabled) return C1;
            if (B1.Text == sign && C1.Text == sign && A1.Enabled) return A1;
            if (A1.Text == sign && C1.Text == sign && B1.Enabled) return B1;

            if (A2.Text == sign && B2.Text == sign && C2.Enabled) return C2;
            if (B2.Text == sign && C2.Text == sign && A2.Enabled) return A2;
            if (A2.Text == sign && C2.Text == sign && B2.Enabled) return B2;

            if (A3.Text == sign && B3.Text == sign && C3.Enabled) return C3;
            if (B3.Text == sign && C3.Text == sign && A3.Enabled) return A3;
            if (A3.Text == sign && C3.Text == sign && B3.Enabled) return B3;

            return null;
        }

        private Button DiagonalComputerMove(string sign)
        {
            if (A1.Text == sign && B2.Text == sign && C3.Enabled) return C3;
            if (B2.Text == sign && C3.Text == sign && A1.Enabled) return A1;
            if (A1.Text == sign && C3.Text == sign && B2.Enabled) return B2;

            if (A3.Text == sign && B2.Text == sign && C1.Enabled) return C1;
            if (B2.Text == sign && C1.Text == sign && A3.Enabled) return A3;
            if (A3.Text == sign && C1.Text == sign && B2.Enabled) return B2;

            return null;
        }
        
        private Button RandomMove()
        {
            Button[] allButtons = { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            return allButtons[random.Next(allButtons.Length)];
        }

        // Convenience methods

        private string IncrementCount(Label countLabel)
        {
            return (int.Parse(countLabel.Text) + 1).ToString();
        }

        #endregion
    }
}