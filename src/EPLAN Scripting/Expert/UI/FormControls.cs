using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;
using System.Windows.Forms;

namespace EPLAN_Scripting.Expert.UI
{
  public class FormControls : Form
  {
    private Button btnCancel;
    private Button btnOk;
    private CheckBox chbReports;
    private CheckBox chbCheck;
    private CheckBox chbAll;
    #region Windows Form Designer generated code

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

    

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.chbReports = new System.Windows.Forms.CheckBox();
      this.chbCheck = new System.Windows.Forms.CheckBox();
      this.chbAll = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Location = new System.Drawing.Point(337, 173);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.Location = new System.Drawing.Point(256, 173);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // chbReports
      // 
      this.chbReports.AutoSize = true;
      this.chbReports.Location = new System.Drawing.Point(13, 13);
      this.chbReports.Name = "chbReports";
      this.chbReports.Size = new System.Drawing.Size(63, 17);
      this.chbReports.TabIndex = 2;
      this.chbReports.Text = "Reports";
      this.chbReports.UseVisualStyleBackColor = true;
      // 
      // chbCheck
      // 
      this.chbCheck.AutoSize = true;
      this.chbCheck.Location = new System.Drawing.Point(13, 37);
      this.chbCheck.Name = "chbCheck";
      this.chbCheck.Size = new System.Drawing.Size(57, 17);
      this.chbCheck.TabIndex = 3;
      this.chbCheck.Text = "Check";
      this.chbCheck.UseVisualStyleBackColor = true;
      // 
      // chbAll
      // 
      this.chbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.chbAll.AutoSize = true;
      this.chbAll.Location = new System.Drawing.Point(13, 178);
      this.chbAll.Name = "chbAll";
      this.chbAll.Size = new System.Drawing.Size(37, 17);
      this.chbAll.TabIndex = 4;
      this.chbAll.Text = "All";
      this.chbAll.UseVisualStyleBackColor = true;
      this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
      // 
      // FormControls
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 208);
      this.Controls.Add(this.chbAll);
      this.Controls.Add(this.chbCheck);
      this.Controls.Add(this.chbReports);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.btnCancel);
      this.Name = "FormControls";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FormTemplate";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    

    public FormControls()
    {
      InitializeComponent();
    }

    #endregion

    [Start]
    public void Function()
    {
      var window = new FormControls();
      window.ShowDialog();
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void chbAll_CheckedChanged(object sender, System.EventArgs e)
    {
      chbCheck.Checked = chbAll.Checked;
      chbReports.Checked = chbAll.Checked;
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
      if (chbCheck.Checked)
      {
        new CommandLineInterpreter().Execute("XMsgActionStartVerification");
      }

      if (chbReports.Checked)
      {
        new CommandLineInterpreter().Execute("reports");
      }

      this.Close();
    }
  }
}
