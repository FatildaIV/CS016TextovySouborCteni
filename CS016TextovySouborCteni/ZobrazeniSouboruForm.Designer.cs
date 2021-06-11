namespace CS016TextovySouborCteni
{
    partial class zobrazeniSouboruForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.souborObsahTextBox = new System.Windows.Forms.TextBox();
            this.souborNacteniButton = new System.Windows.Forms.Button();
            this.souborNactenPostupneiButton = new System.Windows.Forms.Button();
            this.nacitaniZastavitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // souborObsahTextBox
            // 
            this.souborObsahTextBox.Location = new System.Drawing.Point(12, 12);
            this.souborObsahTextBox.Multiline = true;
            this.souborObsahTextBox.Name = "souborObsahTextBox";
            this.souborObsahTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.souborObsahTextBox.Size = new System.Drawing.Size(801, 435);
            this.souborObsahTextBox.TabIndex = 0;
            // 
            // souborNacteniButton
            // 
            this.souborNacteniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.souborNacteniButton.Location = new System.Drawing.Point(357, 453);
            this.souborNacteniButton.Name = "souborNacteniButton";
            this.souborNacteniButton.Size = new System.Drawing.Size(223, 39);
            this.souborNacteniButton.TabIndex = 1;
            this.souborNacteniButton.Text = "Načíst soubor najednou";
            this.souborNacteniButton.UseVisualStyleBackColor = true;
            this.souborNacteniButton.Click += new System.EventHandler(this.souborNacteniButton_Click);
            // 
            // souborNactenPostupneiButton
            // 
            this.souborNactenPostupneiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.souborNactenPostupneiButton.Location = new System.Drawing.Point(586, 453);
            this.souborNactenPostupneiButton.Name = "souborNactenPostupneiButton";
            this.souborNactenPostupneiButton.Size = new System.Drawing.Size(227, 39);
            this.souborNactenPostupneiButton.TabIndex = 2;
            this.souborNactenPostupneiButton.Text = "Načíst soubor postupně";
            this.souborNactenPostupneiButton.UseVisualStyleBackColor = true;
            this.souborNactenPostupneiButton.Click += new System.EventHandler(this.souborNactenPostupneiButton_Click);
            // 
            // nacitaniZastavitButton
            // 
            this.nacitaniZastavitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nacitaniZastavitButton.Location = new System.Drawing.Point(12, 453);
            this.nacitaniZastavitButton.Name = "nacitaniZastavitButton";
            this.nacitaniZastavitButton.Size = new System.Drawing.Size(177, 39);
            this.nacitaniZastavitButton.TabIndex = 3;
            this.nacitaniZastavitButton.Text = "Zastavit načítání";
            this.nacitaniZastavitButton.UseVisualStyleBackColor = true;
            this.nacitaniZastavitButton.Click += new System.EventHandler(this.nacitaniZastavitButton_Click);
            // 
            // zobrazeniSouboruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 504);
            this.Controls.Add(this.nacitaniZastavitButton);
            this.Controls.Add(this.souborNactenPostupneiButton);
            this.Controls.Add(this.souborNacteniButton);
            this.Controls.Add(this.souborObsahTextBox);
            this.Name = "zobrazeniSouboruForm";
            this.Text = "CS016 - Textový soubor čtení - Michal Michna ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox souborObsahTextBox;
        private System.Windows.Forms.Button souborNacteniButton;
        private System.Windows.Forms.Button souborNactenPostupneiButton;
        private System.Windows.Forms.Button nacitaniZastavitButton;
    }
}

