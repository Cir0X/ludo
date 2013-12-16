namespace ludo_client
{
    partial class CreateRoomForm
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
            this.createRoomNameLabel = new System.Windows.Forms.Label();
            this.createRoomNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmCreateRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createRoomNameLabel
            // 
            this.createRoomNameLabel.AutoSize = true;
            this.createRoomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRoomNameLabel.Location = new System.Drawing.Point(4, 9);
            this.createRoomNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createRoomNameLabel.Name = "createRoomNameLabel";
            this.createRoomNameLabel.Size = new System.Drawing.Size(82, 16);
            this.createRoomNameLabel.TabIndex = 0;
            this.createRoomNameLabel.Text = "Roomname:";
            // 
            // createRoomNameTextBox
            // 
            this.createRoomNameTextBox.Location = new System.Drawing.Point(94, 8);
            this.createRoomNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.createRoomNameTextBox.MaxLength = 20;
            this.createRoomNameTextBox.Name = "createRoomNameTextBox";
            this.createRoomNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.createRoomNameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(7, 39);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // confirmCreateRoomButton
            // 
            this.confirmCreateRoomButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confirmCreateRoomButton.Location = new System.Drawing.Point(158, 39);
            this.confirmCreateRoomButton.Name = "confirmCreateRoomButton";
            this.confirmCreateRoomButton.Size = new System.Drawing.Size(75, 23);
            this.confirmCreateRoomButton.TabIndex = 3;
            this.confirmCreateRoomButton.Text = "Create";
            this.confirmCreateRoomButton.UseVisualStyleBackColor = true;
            this.confirmCreateRoomButton.Click += new System.EventHandler(this.confirmCreateRoomButton_Click);
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(246, 65);
            this.ControlBox = false;
            this.Controls.Add(this.confirmCreateRoomButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createRoomNameTextBox);
            this.Controls.Add(this.createRoomNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Name the Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createRoomNameLabel;
        private System.Windows.Forms.TextBox createRoomNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmCreateRoomButton;
    }
}