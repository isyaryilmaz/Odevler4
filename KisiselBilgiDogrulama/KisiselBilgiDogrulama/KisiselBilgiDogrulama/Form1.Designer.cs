namespace KisiselBilgiDogrulama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Label lblBilgi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnDogrula = new Button();
            lblBilgi = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(169, 24);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(169, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(169, 117);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(200, 27);
            txtBolum.TabIndex = 2;
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(169, 195);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(200, 30);
            btnDogrula.TabIndex = 3;
            btnDogrula.Text = "Bilgileri Doğrula";
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.Location = new Point(120, 200);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(300, 60);
            lblBilgi.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(626, 471);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtBolum);
            Controls.Add(btnDogrula);
            Controls.Add(lblBilgi);
            Name = "Form1";
            Text = "Kişisel Bilgi Doğrulama";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

