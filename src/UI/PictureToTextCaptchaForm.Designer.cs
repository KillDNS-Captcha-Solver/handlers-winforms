using System.ComponentModel;

namespace KillDNS.CaptchaSolver.Handlers.WinForms.UI;

partial class PictureToTextCaptchaForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.captchaPictureBox.Location = new System.Drawing.Point(0, 0);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(299, 130);
            this.captchaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.captchaPictureBox.TabIndex = 0;
            this.captchaPictureBox.TabStop = false;
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solutionTextBox.Location = new System.Drawing.Point(0, 136);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(299, 23);
            this.solutionTextBox.TabIndex = 1;
            this.solutionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solutionTextBox_KeyPress);
            // 
            // PictureToTextCaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 159);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.captchaPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PictureToTextCaptchaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureToTextCaptchaForm";
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private PictureBox captchaPictureBox;
    private TextBox solutionTextBox;
}