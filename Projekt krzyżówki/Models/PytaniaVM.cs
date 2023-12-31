﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Projekt_krzyżówki.Models
{
    public class PytaniaVM
    {
        [Display(Name = "Treść pytania")]
        [Required(ErrorMessage = "Treść jest wymagana!")]
        public string TrescPytania { get; set; }
        [Display(Name = "Trudność pytania")]
        [Required(ErrorMessage = "Trudność jest wymagana!")]

        public int TrudnoscPytania { get; set; }
        [Display(Name = "Kategoria pytania")]
        [Required(ErrorMessage = "Kategoria jest wymagana!")]
        public string KategoriaPytania { get; set; }
        [Display(Name = "Słowa-Odpowiedzi (oddzielone przecinkami)")]
        [Required(ErrorMessage = "Co najmniej 1 odpowiedź jest wymagana!")]
        public string Slowa { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa jest wymagana!")]
        public string NazwaSlowa { get; set; }
        [Display(Name = "Kategoria")]
        [Required(ErrorMessage = "Kategoria jest wymagana!")]
        public string KategoriaSlowa { get; set; }
        [Display(Name = "Podkategoria")]
        [Required(ErrorMessage = "Podkategoria jest wymagana!")]
        public int PodkategoriaSlowa { get; set; }
        [Display(Name = "Czy słowo jest anagramem?")]
        public bool CzyAnagram { get; set; }
    }
}
