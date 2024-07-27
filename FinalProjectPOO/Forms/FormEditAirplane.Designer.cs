namespace FinalProjectOOP
{
    partial class FormEditAirplane
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
            textBoxAirplaneCapacity = new TextBox();
            textBoxAirplaneModel = new TextBox();
            textBoxAirplaneBrand = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxAirplaneCapacity
            // 
            textBoxAirplaneCapacity.Location = new Point(479, 461);
            textBoxAirplaneCapacity.Margin = new Padding(4, 5, 4, 5);
            textBoxAirplaneCapacity.Name = "textBoxAirplaneCapacity";
            textBoxAirplaneCapacity.Size = new Size(360, 31);
            textBoxAirplaneCapacity.TabIndex = 25;
            // 
            // textBoxAirplaneModel
            // 
            textBoxAirplaneModel.Location = new Point(479, 379);
            textBoxAirplaneModel.Margin = new Padding(4, 5, 4, 5);
            textBoxAirplaneModel.Name = "textBoxAirplaneModel";
            textBoxAirplaneModel.Size = new Size(360, 31);
            textBoxAirplaneModel.TabIndex = 24;
            // 
            // textBoxAirplaneBrand
            // 
            textBoxAirplaneBrand.Location = new Point(479, 301);
            textBoxAirplaneBrand.Margin = new Padding(4, 5, 4, 5);
            textBoxAirplaneBrand.Name = "textBoxAirplaneBrand";
            textBoxAirplaneBrand.Size = new Size(360, 31);
            textBoxAirplaneBrand.TabIndex = 23;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGreen;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            buttonSave.Image = FinalProjectPOO.Properties.Resources.accept;
            buttonSave.Location = new Point(639, 549);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(135, 135);
            buttonSave.TabIndex = 22;
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Tomato;
            buttonCancel.FlatStyle = FlatStyle.Popup;
            buttonCancel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = FinalProjectPOO.Properties.Resources.cancel;
            buttonCancel.Location = new Point(369, 549);
            buttonCancel.Margin = new Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(135, 135);
            buttonCancel.TabIndex = 21;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(240, 444);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 48);
            label4.TabIndex = 20;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(278, 361);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 48);
            label3.TabIndex = 19;
            label3.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(286, 284);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 48);
            label2.TabIndex = 18;
            label2.Text = "Brand";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(636, 128);
            label1.TabIndex = 17;
            label1.Text = "Edit Airplane";
            // 
            // FormEditAirplane
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1142, 750);
            Controls.Add(textBoxAirplaneCapacity);
            Controls.Add(textBoxAirplaneModel);
            Controls.Add(textBoxAirplaneBrand);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormEditAirplane";
            Text = "Edit Airplane";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAirplaneCapacity;
        private TextBox textBoxAirplaneModel;
        private TextBox textBoxAirplaneBrand;
        private Button buttonSave;
        private Button buttonCancel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}