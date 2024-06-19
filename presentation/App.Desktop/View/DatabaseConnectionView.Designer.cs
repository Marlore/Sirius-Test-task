namespace App.Desktop.View
{
    partial class DatabaseConnectionView
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
            ServerText = new TextBox();
            ServerLabel = new Label();
            DataBaseLabel = new Label();
            DatabaseText = new TextBox();
            TableLable = new Label();
            TableText = new TextBox();
            ConnectButton = new Button();
            SuspendLayout();
            // 
            // ServerText
            // 
            ServerText.Location = new Point(174, 66);
            ServerText.Name = "ServerText";
            ServerText.Size = new Size(144, 23);
            ServerText.TabIndex = 0;
            // 
            // ServerLabel
            // 
            ServerLabel.AutoSize = true;
            ServerLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ServerLabel.Location = new Point(83, 64);
            ServerLabel.Name = "ServerLabel";
            ServerLabel.Size = new Size(69, 25);
            ServerLabel.TabIndex = 1;
            ServerLabel.Text = "Server:";
            // 
            // DataBaseLabel
            // 
            DataBaseLabel.AutoSize = true;
            DataBaseLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DataBaseLabel.Location = new Point(74, 118);
            DataBaseLabel.Name = "DataBaseLabel";
            DataBaseLabel.Size = new Size(94, 25);
            DataBaseLabel.TabIndex = 3;
            DataBaseLabel.Text = "Database:";
            // 
            // DatabaseText
            // 
            DatabaseText.Location = new Point(174, 120);
            DatabaseText.Name = "DatabaseText";
            DatabaseText.Size = new Size(144, 23);
            DatabaseText.TabIndex = 2;
            // 
            // TableLable
            // 
            TableLable.AutoSize = true;
            TableLable.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TableLable.Location = new Point(92, 168);
            TableLable.Name = "TableLable";
            TableLable.Size = new Size(60, 25);
            TableLable.TabIndex = 5;
            TableLable.Text = "Table:";
            // 
            // TableText
            // 
            TableText.Location = new Point(174, 170);
            TableText.Name = "TableText";
            TableText.Size = new Size(144, 23);
            TableText.TabIndex = 4;
            // 
            // ConnectButton
            // 
            ConnectButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ConnectButton.Location = new Point(141, 263);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(119, 54);
            ConnectButton.TabIndex = 6;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // DatabaseConnectionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 378);
            Controls.Add(ConnectButton);
            Controls.Add(TableLable);
            Controls.Add(TableText);
            Controls.Add(DataBaseLabel);
            Controls.Add(DatabaseText);
            Controls.Add(ServerLabel);
            Controls.Add(ServerText);
            Name = "DatabaseConnectionView";
            Text = "DatabaseConnectionView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ServerText;
        private Label ServerLabel;
        private Label DataBaseLabel;
        private TextBox DatabaseText;
        private Label TableLable;
        private TextBox TableText;
        private Button ConnectButton;
    }
}