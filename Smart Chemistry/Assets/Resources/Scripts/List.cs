
public class List
{
    #region Elements List
    public static string[] numbers = new string[10] { "Qual o número atômico do hidrogênio ?", 
                                                      "Qual dos elementos possui número atômico igual a 16?",
                                                      "Sabendo que o número atômico do sódio é 11 e o elemento cloro encontra-se no mesmo período e na família VIIA. Determine o número atômico do cloro.",
                                                      "Qual o número atômico do Carbono ?",
                                                      "Qual dos elementos é gás nobre e possui número atômico 10?",
                                                      "Qual é o número atômico do Cálcio",
                                                      "Qual o número atômico do Alumínio ?",
                                                      "Qual dos elementos é metal alcalino e possui número atômico 19?",
                                                      "Qual dos elementos é halogênio e possui número atômico 9",
                                                      "Qual o número atômico do Nitrogênio ?" }; // perguntas

    public static string[] numbers_right = new string[10] { "1", "Enxofre", "17", "6", "Neônio", "20", "13", "Potássio", "Flúor", "7" }; // corretas
    public static string[] numbers_alt1 = new string[10] { "2", "Flúor", "18", "7", "Argônio", "12", "23", "Sódio", "Cloro", "9" }; // alternativas 1
    public static string[] numbers_alt2 = new string[10] { "3", "Oxigênio", "16", "8", "Nitrogênio", "38", "3", "Carbono", "Bromo", "5" }; // alternativas 2

    public static string[] symbols = new string[10] { "Qual é o símbolo do potássio?",
                                                      "Qual dos elementos possui o símbolo H?",
                                                      "Qual é o símbolo do sódio?",
                                                      "Qual dos elementos possui o símbolo B?",
                                                      "Qual é o símbolo do cobre?",
                                                      "O ferro é um metal de transição. Qual dos símbolos corresponde a esse elemento?",
                                                      "Qual é o símbolo do Enxofre?",
                                                      "Qual é o símbolo do Mercúrio?",
                                                      "Qual é o símbolo do Cálcio?",
                                                       "O Neônio é um gás nobre. Qual dos símbolos corresponde a esse elemento?", }; // perguntas
    public static string[] symbols_right = new string[10] { "K", "Hidrogênio", "Na", "Boro", "Cu", "Fe", "S", "Hg", "Ca", "Ne" }; // corretas
    public static string[] symbols_alt1 = new string[10] { "P", "Hélio", "S", "Berílio", "C", "F", "N", "Mo", "Cs", "N" }; // alternativas 1
    public static string[] symbols_alt2 = new string[10] { "Pt", "Háfnio", "K", "Bromo", "Co", "Fr", "P", "Mc", "C", "Nh" }; // alternativas 2

    public static string[] names = new string[10] { "O símbolo H representa qual elemento?",
                                                    "O símbolo P representa qual elemento?",
                                                    "O símbolo C representa qual elemento?",
                                                    "Qual dos elementos é radioativo?",
                                                    "O símbolo N representa qual elemento?",
                                                    "É um elemento usado no transporte de oxigenio pelas hemoglobinas. Qual?",
                                                    "O símbolo F representa qual elemento?",
                                                    "Qual dos elementos é essencial para o precesso de respiração?",
                                                    "O símbolo K representa qual elemento?",
                                                    "O símbolo Pb representa qual elemento?", }; // perguntas
    public static string[] names_right = new string[10] { "Hidrogênio", "Fósforo", "Carbono", "Urânio", "Nitrogênio", "Ferro", "Flúor", "Oxigênio", "Potássio", "Chumbo" }; // corretas
    public static string[] names_alt1 = new string[10] { "Helio", "Polônio", "Cobre", "Cobalto", "Neônio", "Carbono", "Fósforo", "Nitrogênio", "Cálcio", "Mercúrio" }; // alternativas 1
    public static string[] names_alt2 = new string[10] { "Háfnio", "Chumbo", "Cobalto", "Lítio", "Nióbio", "Potássio", "Ferro", "Hidrogênio", "Criptônio", "Platina" }; // alternativas 2

    public static int[] mass = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // perguntas
    public static string[] mass_right = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; // corretas
    public static string[] mass_alt1 = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; // alternativas 1
    public static string[] mass_alt2 = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" }; // alternativas 2

    public static string[] period = new string[10] { "Em qual período encontra-se o elemento Hidrogênio?",
                                                     "Em qual período encontra-se o elemento Potássio?",
                                                     "Em qual período encontra-se o elemento Carbono?",
                                                     "Em qual período encontra-se o elemento Ferro?",
                                                     "Em qual período encontra-se o elemento Hélio?",
                                                     "Em qual período encontra-se o elemento Cobre?",
                                                     "Em qual período encontra-se o elemento Oxigênio?",
                                                     "Em qual período encontra-se o elemento Fósforo?",
                                                     "Em qual período encontra-se o elemento Cálcio?",
                                                     "Em qual período encontra-se o elemento Mercúrio?", }; // perguntas
    public static int[] period_right = new int[10] { 1, 4, 2, 4, 1, 4, 2, 3, 4, 6 }; // corretas
    public static int[] period_alt1 = new int[10] { 2, 3, 3, 5, 3, 5, 3, 4, 5, 5 }; // alternativas 1
    public static int[] period_alt2 = new int[10] { 3, 2, 4, 6, 4, 6, 4, 5, 3, 7 }; // alternativas 2

    public static string[] family = new string[10] { "Qual família representa os metais alcalinos?",
                                                     "Em qual família está o elemento cloro?",
                                                     "Qual família representa os metais alcalinos terrosos?",
                                                     "Em qual família está o elemento hélio?",
                                                     "Qual família representa os calcogênios?",
                                                     "Em qual família está o elemento carbono?",
                                                     "Qual família representa os gases nobres?",
                                                     "Em qual família está o elemento boro?",
                                                     "Qual família representa os halogênios?",
                                                     "Em qual família está o elemento magnésio?"}; // perguntas
    public static string[] family_right = new string[10] { "1A", "7A", "2A", "8A", "6A", "4A", "8A", "3A", "7A", "2A" }; // corretas
    public static string[] family_alt1 = new string[10] { "2A", "6A", "3A", "1A", "5A", "5A", "7A", "2A", "8A", "3A" }; // alternativas 1
    public static string[] family_alt2 = new string[10] { "3A", "5A", "4A", "2A", "4A", "3A", "6A", "5A", "6A", "4A" }; // alternativas 2
    #endregion
}