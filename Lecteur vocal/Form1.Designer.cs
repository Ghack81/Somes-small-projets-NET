namespace TTS_en_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.etat = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Buttonetat = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.lectureasynchrone = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.stopper = new System.Windows.Forms.Button();
            this.reprendre = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.lecture = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Buttonlist = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.champtexte = new System.Windows.Forms.RichTextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // etat
            // 
            this.etat.Location = new System.Drawing.Point(148, 31);
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(100, 20);
            this.etat.TabIndex = 19;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Buttonetat);
            this.GroupBox1.Controls.Add(this.etat);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupBox1.Location = new System.Drawing.Point(288, 16);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(275, 79);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Vérification de l\'état de  lecture :";
            // 
            // Buttonetat
            // 
            this.Buttonetat.Location = new System.Drawing.Point(27, 28);
            this.Buttonetat.Name = "Buttonetat";
            this.Buttonetat.Size = new System.Drawing.Size(75, 23);
            this.Buttonetat.TabIndex = 16;
            this.Buttonetat.Text = "Etat";
            this.Buttonetat.UseVisualStyleBackColor = true;
            this.Buttonetat.Click += new System.EventHandler(this.Buttonetat_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.GroupBox6);
            this.GroupBox3.Controls.Add(this.GroupBox5);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox3.Location = new System.Drawing.Point(0, 101);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(566, 91);
            this.GroupBox3.TabIndex = 24;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Action sur la lecture :";
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.lectureasynchrone);
            this.GroupBox6.Controls.Add(this.pause);
            this.GroupBox6.Controls.Add(this.stopper);
            this.GroupBox6.Controls.Add(this.reprendre);
            this.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupBox6.Location = new System.Drawing.Point(173, 16);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(390, 72);
            this.GroupBox6.TabIndex = 17;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Méthode asyncrone :";
            // 
            // lectureasynchrone
            // 
            this.lectureasynchrone.Location = new System.Drawing.Point(21, 32);
            this.lectureasynchrone.Name = "lectureasynchrone";
            this.lectureasynchrone.Size = new System.Drawing.Size(115, 23);
            this.lectureasynchrone.TabIndex = 12;
            this.lectureasynchrone.Text = "lecture assynchrone";
            this.lectureasynchrone.UseVisualStyleBackColor = true;
            this.lectureasynchrone.Click += new System.EventHandler(this.lectureasynchrone_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(142, 32);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 13;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stopper
            // 
            this.stopper.Location = new System.Drawing.Point(304, 32);
            this.stopper.Name = "stopper";
            this.stopper.Size = new System.Drawing.Size(75, 23);
            this.stopper.TabIndex = 15;
            this.stopper.Text = "stop";
            this.stopper.UseVisualStyleBackColor = true;
            this.stopper.Click += new System.EventHandler(this.stopper_Click);
            // 
            // reprendre
            // 
            this.reprendre.Location = new System.Drawing.Point(223, 32);
            this.reprendre.Name = "reprendre";
            this.reprendre.Size = new System.Drawing.Size(75, 23);
            this.reprendre.TabIndex = 14;
            this.reprendre.Text = "reprendre";
            this.reprendre.UseVisualStyleBackColor = true;
            this.reprendre.Click += new System.EventHandler(this.reprendre_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.lecture);
            this.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox5.Location = new System.Drawing.Point(3, 16);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(164, 72);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Méthode synchrone :";
            // 
            // lecture
            // 
            this.lecture.Location = new System.Drawing.Point(16, 32);
            this.lecture.Name = "lecture";
            this.lecture.Size = new System.Drawing.Size(100, 23);
            this.lecture.TabIndex = 11;
            this.lecture.Text = "lecture synchrone";
            this.lecture.UseVisualStyleBackColor = true;
            this.lecture.Click += new System.EventHandler(this.lecture_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ListBox);
            this.GroupBox2.Controls.Add(this.Buttonlist);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox2.Location = new System.Drawing.Point(3, 16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(279, 79);
            this.GroupBox2.TabIndex = 21;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Liste des voix installée sur l\'ordinateur :";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(104, 19);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(169, 56);
            this.ListBox.TabIndex = 18;
            // 
            // Buttonlist
            // 
            this.Buttonlist.Location = new System.Drawing.Point(6, 19);
            this.Buttonlist.Name = "Buttonlist";
            this.Buttonlist.Size = new System.Drawing.Size(75, 23);
            this.Buttonlist.TabIndex = 17;
            this.Buttonlist.Text = "lister les voix";
            this.Buttonlist.UseVisualStyleBackColor = true;
            this.Buttonlist.Click += new System.EventHandler(this.Buttonlist_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.GroupBox1);
            this.GroupBox4.Controls.Add(this.GroupBox2);
            this.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox4.Location = new System.Drawing.Point(0, 192);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(566, 98);
            this.GroupBox4.TabIndex = 23;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Encore plus loin :";
            // 
            // champtexte
            // 
            this.champtexte.Dock = System.Windows.Forms.DockStyle.Top;
            this.champtexte.Location = new System.Drawing.Point(0, 0);
            this.champtexte.Name = "champtexte";
            this.champtexte.Size = new System.Drawing.Size(566, 96);
            this.champtexte.TabIndex = 22;
            this.champtexte.Text = "Ceci est un texte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 290);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.champtexte);
            this.Name = "Form1";
            this.Text = "Lecteur Vocal";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox etat;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Buttonetat;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Button lectureasynchrone;
        internal System.Windows.Forms.Button pause;
        internal System.Windows.Forms.Button stopper;
        internal System.Windows.Forms.Button reprendre;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button lecture;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ListBox ListBox;
        internal System.Windows.Forms.Button Buttonlist;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.RichTextBox champtexte;


    }
}

