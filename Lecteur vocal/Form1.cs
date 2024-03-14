using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TTS_en_Csharp
{
    public partial class Form1 : Form
    {
        public SpeechSynthesizer parole = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        public bool verifvoix(string voix)
        {
            bool test = false; //déclaration et attribution de la valeur False à notre variable booléenne 
            foreach (InstalledVoice unevoix in parole.GetInstalledVoices()) //liste des voix dans notre for
            {
                if (unevoix.VoiceInfo.Name == voix) //'on vérifie que la voix est égale à notre argument
                {
                    test = true; //si oui, on attribue la valeur True à test
                    break;  //on quitte notre For
                }
            }
            return test; //on renvoie la valeur de test
        }

        private void lecture_Click(object sender, EventArgs e)
        {
            string voix = "ScanSoft Virginie_Dri40_16kHz";

            if (verifvoix(voix)) // Si la voix est installée
            parole.SelectVoice(voix); // Alors on l'utilise //appel de la fonction verifvoix avec la voix de Virginie en argument
            parole.Speak(champtexte.Text); //lecture du texte
        }

        private void lectureasynchrone_Click(object sender, EventArgs e)
        {
            //même qu'au dessus mais de façon asynchrone
            string voix = "ScanSoft Virginie_Dri40_16kHz";

            if (verifvoix(voix))
            parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz");
            parole.SpeakAsync(champtexte.Text);
        }

        private void pause_Click(object sender, EventArgs e)
        {
            parole.Pause(); //lecture en pause (seulement pour la méthode asynchrone)
        }

        private void reprendre_Click(object sender, EventArgs e)
        {
            parole.Resume(); //reprise de la lecture (seulement pour la méthode asynchrone)
        }

        private void stopper_Click(object sender, EventArgs e)
        {
            parole.SpeakAsyncCancelAll(); //arrêt de la lecture (seulement pour la méthode asynchrone)
        }

        private void Buttonlist_Click(object sender, EventArgs e)
        {
            foreach (InstalledVoice unevoix in parole.GetInstalledVoices()) //liste des voix installée
            {
                ListBox.Items.Add(unevoix.VoiceInfo.Name); //on ajoute le nom des voix installée dans notre listbox
            }
        }

        private void Buttonetat_Click(object sender, EventArgs e)
        {
            switch (parole.State)  //état de notre lecture (seulement pour la méthode asynchrone)
            {
                case SynthesizerState.Ready:
                    etat.Text = "Ready"; //prêt
                    break;
                case SynthesizerState.Speaking:
                    etat.Text = "Speaking"; //en cours de parole
                    break;
                case SynthesizerState.Paused:
                    etat.Text = "Paused"; //en pause
                    break;
            }
        }

       


    }
}
