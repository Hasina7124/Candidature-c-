﻿namespace Candidature
{
    partial class Listecandidat
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
            this.conteneur = new System.Windows.Forms.Panel();
            this.imagecandidats = new System.Windows.Forms.PictureBox();
            this.listcandidats = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.retour = new System.Windows.Forms.Button();
            this.suppression = new System.Windows.Forms.Button();
            this.modification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.conteneur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecandidats)).BeginInit();
            this.SuspendLayout();
            // 
            // conteneur
            // 
            this.conteneur.Controls.Add(this.imagecandidats);
            this.conteneur.Controls.Add(this.listcandidats);
            this.conteneur.Controls.Add(this.retour);
            this.conteneur.Controls.Add(this.suppression);
            this.conteneur.Controls.Add(this.modification);
            this.conteneur.Controls.Add(this.label1);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 0);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(1150, 400);
            this.conteneur.TabIndex = 0;
            // 
            // imagecandidats
            // 
            this.imagecandidats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagecandidats.Location = new System.Drawing.Point(936, 46);
            this.imagecandidats.Name = "imagecandidats";
            this.imagecandidats.Size = new System.Drawing.Size(139, 142);
            this.imagecandidats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagecandidats.TabIndex = 29;
            this.imagecandidats.TabStop = false;
            // 
            // listcandidats
            // 
            this.listcandidats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listcandidats.FullRowSelect = true;
            this.listcandidats.GridLines = true;
            this.listcandidats.HideSelection = false;
            this.listcandidats.Location = new System.Drawing.Point(12, 80);
            this.listcandidats.MultiSelect = false;
            this.listcandidats.Name = "listcandidats";
            this.listcandidats.Size = new System.Drawing.Size(853, 308);
            this.listcandidats.TabIndex = 28;
            this.listcandidats.UseCompatibleStateImageBehavior = false;
            this.listcandidats.View = System.Windows.Forms.View.Details;
            this.listcandidats.Click += new System.EventHandler(this.listcandidats_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenoms";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numeros";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Politique";
            this.columnHeader4.Width = 200;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(936, 344);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(140, 41);
            this.retour.TabIndex = 27;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            // 
            // suppression
            // 
            this.suppression.Location = new System.Drawing.Point(936, 283);
            this.suppression.Name = "suppression";
            this.suppression.Size = new System.Drawing.Size(140, 41);
            this.suppression.TabIndex = 26;
            this.suppression.Text = "Supprimer";
            this.suppression.UseVisualStyleBackColor = true;
            // 
            // modification
            // 
            this.modification.Location = new System.Drawing.Point(936, 222);
            this.modification.Name = "modification";
            this.modification.Size = new System.Drawing.Size(140, 41);
            this.modification.TabIndex = 25;
            this.modification.Text = "Modification";
            this.modification.UseVisualStyleBackColor = true;
            this.modification.Click += new System.EventHandler(this.modification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTE CANDIDAT";
            // 
            // Listecandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 400);
            this.Controls.Add(this.conteneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listecandidat";
            this.Text = "Listecandidat";
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagecandidats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button suppression;
        private System.Windows.Forms.Button modification;
        private System.Windows.Forms.ListView listcandidats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox imagecandidats;
    }
}