namespace FinalProjectOOP
{
    partial class FormCRUDAirplanes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDeleteAirplane = new Button();
            buttonEditAirplane = new Button();
            panel2 = new Panel();
            label1 = new Label();
            listBoxAvailableAirplanes = new ListBox();
            panel1 = new Panel();
            labelCapacity = new Label();
            comboBoxModel = new ComboBox();
            comboBoxBrand = new ComboBox();
            label5 = new Label();
            buttonSave = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDeleteAirplane
            // 
            buttonDeleteAirplane.BackColor = Color.Tomato;
            buttonDeleteAirplane.FlatStyle = FlatStyle.Popup;
            buttonDeleteAirplane.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteAirplane.Image = FinalProjectPOO.Properties.Resources.delete;
            buttonDeleteAirplane.Location = new Point(799, 854);
            buttonDeleteAirplane.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteAirplane.Name = "buttonDeleteAirplane";
            buttonDeleteAirplane.Size = new Size(135, 135);
            buttonDeleteAirplane.TabIndex = 10;
            buttonDeleteAirplane.UseVisualStyleBackColor = false;
            buttonDeleteAirplane.Click += buttonDeleteAirplane_Click;
            // 
            // buttonEditAirplane
            // 
            buttonEditAirplane.BackColor = Color.Bisque;
            buttonEditAirplane.FlatStyle = FlatStyle.Popup;
            buttonEditAirplane.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditAirplane.Image = FinalProjectPOO.Properties.Resources.edit;
            buttonEditAirplane.Location = new Point(799, 666);
            buttonEditAirplane.Margin = new Padding(4, 5, 4, 5);
            buttonEditAirplane.Name = "buttonEditAirplane";
            buttonEditAirplane.Size = new Size(135, 135);
            buttonEditAirplane.TabIndex = 9;
            buttonEditAirplane.UseVisualStyleBackColor = false;
            buttonEditAirplane.Click += buttonEditAirplane_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(listBoxAvailableAirplanes);
            panel2.Location = new Point(965, 16);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1958, 1525);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(802, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(352, 45);
            label1.TabIndex = 1;
            label1.Text = "Current Airplanes List:";
            // 
            // listBoxAvailableAirplanes
            // 
            listBoxAvailableAirplanes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxAvailableAirplanes.FormattingEnabled = true;
            listBoxAvailableAirplanes.ItemHeight = 32;
            listBoxAvailableAirplanes.Location = new Point(0, 112);
            listBoxAvailableAirplanes.Margin = new Padding(4, 5, 4, 5);
            listBoxAvailableAirplanes.Name = "listBoxAvailableAirplanes";
            listBoxAvailableAirplanes.Size = new Size(1958, 1348);
            listBoxAvailableAirplanes.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelCapacity);
            panel1.Controls.Add(comboBoxModel);
            panel1.Controls.Add(comboBoxBrand);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 16);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 620);
            panel1.TabIndex = 7;
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(335, 292);
            labelCapacity.Margin = new Padding(4, 0, 4, 0);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(19, 25);
            labelCapacity.TabIndex = 11;
            labelCapacity.Text = "-";
            // 
            // comboBoxModel
            // 
            comboBoxModel.Enabled = false;
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(335, 204);
            comboBoxModel.Margin = new Padding(4, 5, 4, 5);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(360, 33);
            comboBoxModel.TabIndex = 11;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(335, 120);
            comboBoxBrand.Margin = new Padding(4, 5, 4, 5);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(360, 33);
            comboBoxBrand.TabIndex = 10;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(290, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(355, 45);
            label5.TabIndex = 9;
            label5.Text = "Register New Airplane";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            buttonSave.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSave.Location = new Point(558, 466);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 135);
            buttonSave.TabIndex = 5;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            button2.Image = FinalProjectPOO.Properties.Resources.cancel;
            button2.Location = new Point(249, 466);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(135, 135);
            button2.TabIndex = 4;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(184, 292);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 3;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(206, 204);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(214, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 1;
            label2.Text = "Brand";
            // 
            // FormCRUDAirplanes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2968, 1685);
            Controls.Add(buttonDeleteAirplane);
            Controls.Add(buttonEditAirplane);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCRUDAirplanes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Airplanes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDeleteAirplane;
        private Button buttonEditAirplane;
        private Panel panel2;
        private Label label1;
        private ListBox listBoxAvailableAirplanes;
        private Panel panel1;
        private Label label5;
        private Button buttonSave;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxModel;
        private ComboBox comboBoxBrand;
        private Label labelCapacity;
    }
}