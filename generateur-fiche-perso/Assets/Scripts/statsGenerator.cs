using System;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using TMPro;

public class statsGenerator : MonoBehaviour
{
    [SerializeField] private TMP_Text visage;
    [SerializeField] private TMP_Text sexualite;
    [SerializeField] private TMP_Text cheveux;
    [SerializeField] private TMP_Text couleurCheveux;
    [SerializeField] private TMP_Text rdmNom;
    [SerializeField] private TMP_Text rdmPrenom;
    [SerializeField] private TMP_Text genre;
    [SerializeField] private TMP_Text age;
    [SerializeField] private TMP_Text yeux;
    [SerializeField] private TMP_Text taille;
    [SerializeField] private TMP_Text aime;
    [SerializeField] private TMP_Text aimePas;
    
    
            List<string> listePrenoms = new List<string>
            {
                "James", "John", "Robert", "Michael", "William",
                "David", "Richard", "Joseph", "Thomas", "Charles",
                "Christopher", "Daniel", "Matthew", "Anthony", "Mark",
                "Donald", "Steven", "Paul", "Andrew", "Joshua"
            };

            List<string> listeNoms = new List<string>
            {
                "Smith", "Johnson", "Williams", "Brown", "Jones",
                "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
                "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson",
                "Taylor", "Moore", "Jackson", "Martin", "Lee"
            };
            

            

            List<string> listeGenres = new List<string>
            {
                "Homme", "Femme", "Non-Binaire"
            };

            
            
            List<string> couleurs = new List<string>
            {
                "Rouge",
                "Bleu",
                "Vert",
                "Jaune",
                "Orange",
                "Violet",
                "Rose",
                "Marron",
                "Noir",
                "Blanc",
                "Gris",
                "Cyan",
                "Magenta",
                "Beige",
                "Turquoise"
            };

            

            List<string> typeCheveux = new List<string>
            {
                "Longs","Courts","Chauve"
            };
            
            
            List<string> listeSexualite = new List<string>
            {
                "Hétérosexuel",
                "Homosexuel",
                "Bisexuel",
                "Pansexuel",
                "Asexuel",
                "Demi-sexuel",
                "Queer",
                "Omnisexuel",
                "Sapiosexuel",
                "Androsexuel",
                "Gynosexuel"
            };

           
            
            List<string> listeVisages = new List<string>
            {
                "Ovale",
                "Rond",
                "Carré",
                "Rectangulaire",
                "Allongé",
                "Diamant",
                "Cœur",
                "Triangle",
                "Trapèze",
                "Poire"
            };

            List<string> listeYeux = new List<string>
            {
                "En amande",
                "Ronds",
                "Enfoncés",
                "Proéminents",
                "Écartés",
                "Rapprochés",
                "Monolid",
                "Double paupière",
                "Tombants",
                "Relevés"
            };
            
            List<string> passionsEtGouts = new List<string>
            {
                "La musique",
                "Le sport",
                "La lecture",
                "Les voyages",
                "Le cinéma",
                "La cuisine",
                "Les jeux vidéo",
                "La nature",
                "La peinture",
                "La danse",
                "La photographie",
                "Les animaux",
                "L'écriture",
                "La mode",
                "La technologie"
            };
            
            List<string> chosesNaimePas = new List<string>
            {
                "Le mensonge",
                "L'injustice",
                "Le bruit excessif",
                "La trahison",
                "L'attente",
                "La pollution",
                "Les embouteillages",
                "Les disputes",
                "Le désordre",
                "Les mauvaises odeurs",
                "L'arrogance",
                "L'intolérance",
                "Le gaspillage",
                "La routine",
                "Le stress"
            };
    public void Start()
    {
        DisplayRandomCharacter();
    } 
    
    public void DisplayRandomCharacter()
        {
            Debug.Log("caca");
            #region GenerateAttribute
            visage.text = listeVisages[Random.Range(0, listeVisages.Count)].ToString();
            sexualite.text = listeSexualite[Random.Range(0, listeSexualite.Count)].ToString();
            cheveux.text = typeCheveux[Random.Range(0,typeCheveux.Count)].ToString();
            couleurCheveux.text = couleurs[Random.Range(0, couleurs.Count)].ToString();
            rdmNom.text = listePrenoms[Random.Range(0, listeNoms.Count)].ToString();
            rdmPrenom.text = listePrenoms[Random.Range(0, listePrenoms.Count)].ToString();
            genre.text = listeGenres[Random.Range(0, 2)].ToString();
            age.text = Random.Range(7, 120).ToString();
            taille.text = Math.Round(Random.Range((float)1.5, (float)2.3),2).ToString();
            yeux.text = listeYeux[Random.Range(0, listeYeux.Count)].ToString();
            aime.text = passionsEtGouts[Random.Range(0, passionsEtGouts.Count)].ToString();
            aimePas.text = chosesNaimePas[Random.Range(0, chosesNaimePas.Count)].ToString();
            #endregion
        }
}