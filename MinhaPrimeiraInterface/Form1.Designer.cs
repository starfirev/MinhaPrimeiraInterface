namespace MinhaPrimeiraInterface;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        txtIdade = new System.Windows.Forms.TextBox();
        btnCalcular = new System.Windows.Forms.Button();
        lblResultado = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(45, 49);
        label1.Margin = new System.Windows.Forms.Padding(0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(227, 21);
        label1.TabIndex = 0;
        label1.Text = " Digite a idade do seu cachorro:";
        // 
        // txtIdade
        // 
        txtIdade.Location = new System.Drawing.Point(51, 105);
        txtIdade.Margin = new System.Windows.Forms.Padding(0);
        txtIdade.Name = "txtIdade";
        txtIdade.Size = new System.Drawing.Size(325, 29);
        txtIdade.TabIndex = 1;
        // 
        // btnCalcular
        // 
        btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnCalcular.Location = new System.Drawing.Point(51, 178);
        btnCalcular.Margin = new System.Windows.Forms.Padding(0);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(327, 64);
        btnCalcular.TabIndex = 2;
        btnCalcular.Text = "Calcular Idade Canina";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // lblResultado
        // 
        lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblResultado.ForeColor = System.Drawing.Color.DarkSlateGray;
        lblResultado.Location = new System.Drawing.Point(45, 283);
        lblResultado.Margin = new System.Windows.Forms.Padding(0);
        lblResultado.MaximumSize = new System.Drawing.Size(301, 70);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new System.Drawing.Size(301, 70);
        lblResultado.TabIndex = 3;
        lblResultado.Text = " O resultado aparecerá aqui.";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(441, 374);
        Controls.Add(lblResultado);
        Controls.Add(btnCalcular);
        Controls.Add(txtIdade);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(35, 35);
        Margin = new System.Windows.Forms.Padding(4);
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Calculadora de Idade Canina";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblResultado;

    private System.Windows.Forms.Button btnCalcular;

    private System.Windows.Forms.TextBox txtIdade;

    private System.Windows.Forms.Label label1;

    #endregion
}
