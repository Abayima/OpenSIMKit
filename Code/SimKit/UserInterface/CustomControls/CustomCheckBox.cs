using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimKit.UserInterface.CustomControls
{
    public partial class CustomCheckBox : UserControl
    {
        #region Fields

        private bool isSelected = true;

        #endregion

        #region Properties

        public bool Selected
        {
            get { return this.isSelected; }
        }

        #endregion

        #region Constructors

        public CustomCheckBox()
        {
            //Build the base UI
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void leftButton_Click(object sender, EventArgs e)
        {
            SetYesSelectedUI();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            SetNoSelectedUI();
        }

        #endregion

        #region Methods

        private void SetYesSelectedUI()
        {
            this.isSelected = true;
            this.leftPanel.ForeColor = Color.White;
            this.leftButton.NormalImage = global::SimKit.Properties.Resources.app_button_left_blue_out;
            this.leftButton.HoverImage = global::SimKit.Properties.Resources.app_button_left_blue_over;
            this.rightPanel.ForeColor = Color.Black;
            this.rightButton.NormalImage = global::SimKit.Properties.Resources.app_button_right_grey_out;
            this.rightButton.HoverImage = global::SimKit.Properties.Resources.app_button_right_grey_over;
        }

        private void SetNoSelectedUI()
        {
            this.isSelected = false;
            this.rightPanel.ForeColor = Color.White;
            this.rightButton.NormalImage = global::SimKit.Properties.Resources.app_button_right_blue_out;
            this.rightButton.HoverImage = global::SimKit.Properties.Resources.app_button_right_blue_over;
            this.leftPanel.ForeColor = Color.Black;
            this.leftButton.NormalImage = global::SimKit.Properties.Resources.app_button_left_grey_out;
            this.leftButton.HoverImage = global::SimKit.Properties.Resources.app_button_left_grey_over;
        }

        #endregion  
    }
}
