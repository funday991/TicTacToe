using System;
using System.Windows.Forms;


namespace TicTacToe
{
    public partial class PlayerNamesForm : Form
    {
        /* PROPERTIES */
        #region Properties

        // Complex properties

        string _XPlayerName;
        public string XPlayerName
        {
            get { return _XPlayerName; }

            set
            {
                xPlayerTextBox.Text = value;
                _XPlayerName = value;
            }
        }

        string _OPlayerName;
        public string OPlayerName
        {
            get { return _OPlayerName; }

            set
            {
                oPlayerTextBox.Text = value;
                _OPlayerName = value;
            }
        }

        // Stored properties

        public TicTacToeForm gameForm;
        private bool startGameButtonClicked = false;

        #endregion


        /* LIFECYCLE */
        #region Lifecycle

        public PlayerNamesForm()
        {
            InitializeComponent();
        }

        private void PlayerNamesForm_Load(object sender, EventArgs e)
        {
            ToggleRadioButtonsEnabledState();
        }

        private void PlayerNamesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!startGameButtonClicked) Application.Exit();
        }

        #endregion


        /* EVENT HANDLERS */
        #region Event Handlers

        // Start game button events

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            startGameButtonClicked = true;

            gameForm.SetPlayerNames(xPlayerTextBox.Text, oPlayerTextBox.Text);
            gameForm.SetOnePlayerModeTo(onePlayerModeCheckBox.Checked);

            Close();
        }

        // Player textbox events

        private void PlayerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                startGameButton.PerformClick();
            }
        }

        // One player mode checkbox events

        private void OnePlayerModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtonsEnabledState();

            switch (onePlayerModeCheckBox.Checked)
            {
                case true:
                    ToggleTextBoxesState();
                    break;
                case false:
                    EnableTextBox(xPlayerTextBox, XPlayerName);
                    EnableTextBox(oPlayerTextBox, OPlayerName);
                    break;
            }
        }

        // X radio button events

        private void XRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (onePlayerModeCheckBox.Checked) ToggleTextBoxesState();
        }

        #endregion


        /* PUBLIC METHODS */
        #region Public Methods

        public void SetupCheckBoxWithCheckedState(bool isOnePLayerMode, bool xRoleIsSelected)
        {
            onePlayerModeCheckBox.Checked = isOnePLayerMode;

            if (xRoleIsSelected) xRadioButton.Checked = true;
            else oRadioButton.Checked = true;

            if (onePlayerModeCheckBox.Checked) ToggleTextBoxesState();
        }

        #endregion


        /* PRIVATE METHODS */
        #region Private Methods

        private void ToggleTextBoxesState()
        {
            if (xRadioButton.Checked)
            {
                gameForm.SetRoleToX(true);
                DisableTextBox(oPlayerTextBox);
                EnableTextBox(xPlayerTextBox, XPlayerName);
            }
            else if (oRadioButton.Checked)
            {
                gameForm.SetRoleToX(false);
                DisableTextBox(xPlayerTextBox);
                EnableTextBox(oPlayerTextBox, OPlayerName);
            }
        }

        private void EnableTextBox(TextBox textBox, string playerName)
        {
            textBox.Text = playerName == "Computer" ? "" : playerName;
            textBox.Enabled = true;
        }
        
        private void DisableTextBox(TextBox textBox)
        {
            textBox.Text = "Computer";
            textBox.Enabled = false;
        }

        private void ToggleRadioButtonsEnabledState()
        {
            xRadioButton.Enabled = onePlayerModeCheckBox.Checked;
            oRadioButton.Enabled = onePlayerModeCheckBox.Checked;
        }

        #endregion
    }
}
