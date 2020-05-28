using UnityEditor;
using UnityEngine;

public class Algos : MonoBehaviour
{
	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 1 :
	//Ecrit une fonction qui renvoi toujours un entier de valeur 2;

	static int Deux()
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 2 :
	//Ecrit une fonction qui renvoi toujours une string de valeur "bonjour";

	static string Bonjour()
	{
		return "";
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 3 :
	//Ecrit une fonction qui prend un paramètre de type int et renvoi un int du double de sa valeur

	static int Double(int valeur)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 4
	//Ecrit une fonction qui prend un paramètre de type int et renvoi sa valeur + 10

	static int Ajoute10(int valeur2)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 5
	//Ecrit une fonction qui prend un paramètre de type int et renvoi sa valeur * 10 + 5

	static int Fois10Plus5(int valeur3)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 6
	//Ecrit une fonction qui prend un paramètre de type string et qui lui ajoute la chaine "David" à la fin avant de la renvoyer

	static string AjouteDavid(string valeur4)
	{
		return "";
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 7
	//Ecrit une fonction qui prend 2 paramètres de type int et qui renvoit leur somme

	static int Somme(int valeur5, int valeur6)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 8
	//Ecrit une fonction qui prend un paramètre de type string et qui renvoi sa taille

	static int CharacterSize(string chaine)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 9
	//Ecrit une fonction qui prend un paramètre de type string et qui supprime le 4e caractere

	static string CharacterCut4(string chaine)
	{
		return "";
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 10
	//Ecrit une fonction qui prend un paramètre de type string et qui remplace le premier caractère avec 'X'

	static string CharacterX(string resultat8)
	{
		return "";
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 11
	//Ecrit une fonction qui prend un paramètre val de type float et qui renvoi un float qui vaut val divisé par 2;

	static float DivisePar2(float val)
	{
		return 0.0f;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 12
	//Ecrit une fonction qui prend un paramètre val de type float et qui renvoi un float qui vaut racine carré de val;

	static float Racine(float val)
	{
		return 0.0f;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 13
	//Ecrit une fonction qui prend 2 paramètre de type int et qui renvoi le plus grand;

	static int PlusGrand(int val1, int val2)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 14
	//Ecrit une fonction qui prend 3 paramètres de type int et qui renvoi le plus grand;

	static int PlusGrand(int val1, int val2, int val3)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 15
	//Ecrit une fonction qui prend un paramètre val de type int et qui renvoi la somme de nombre de 1 à val;
	// 0 => 0
	// 3 => 1+2+3 = 6
	// 4 => 1+2+3+4 = 10

	static int SommeListe(int val)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	//Exo 16
	//Additionner La somme des nombres pairs entre 0 et le paramètre
	// 0 => 0
	// 1 => 0
	// 3 => 2 = 2
	// 4 => 2+4 = 6
	// 10 => 2+4+6+8+10 = 6

	static int AdditionNbPairs(int val)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 17
	// Renvoyer la taille d'une chaine de caractère

	static string NextString(string chaine)
	{
		return "";
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 18
	// Renvoyer la taille d'un tableau passé en paramètre

	static int TailleTableau(int[] tableau)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 19
	// Renvoyer la somme des nombres d'un tableau passé en parametre

	static int SommeTableau(int[] tableau)
	{
		return 0;
	}


	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 20
	// Renvoyer la moyenne des nombres d'un tableau passé en parametre

	static int MoyenneTableau(int[] tableau)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 21
	// Renvoyer le plus grand des nombres d'un tableau passé en parametre

	static int PlusGrand(int[] tableau)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 22
	// Renvoyer le nombre de voyelles d'une chaine de caractère

	static int NbVoyelles(string word)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 23
	// Indiquer le nombre de pair de lettres concecutives
	// "aa" => 1
	// "aabb" => 2
	// "aaa" => 2
	// "abababa" => 0

	static int LettreIdentiqueConcecutive(string word)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 24
	// Trier un tableau passé en paramètre

	static int[] Trier(int[] tableau)
	{
		return tableau;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 25
	// Ecrire une methode qui renvoie le n-ème élément de la suite de fibonacci
	// Fibo(0) = 1
	// Fibo(1) = 1
	// Fibo(2) = 2
	// Fibo(3) = 3
	// Fibo(4) = 5
	// Fibo(5) = 8
	// ...

	static int Fibo(int nb)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
	// Exo 26
	// Ecrire une methode qui compte le nombre d'occurence de 2 dans un entier
	// NbDeux(0) = 0
	// NbDeux(2) = 1
	// NbDeux(2222) = 4
	// NbDeux(12345) = 1
	// NbDeux(20202) = 3
	// NbDeux(-122) = 2

	static int NbDeux(int nb)
	{
		return 0;
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////

	static int[] tableau;

	[UnityEditor.MenuItem("KCM/Algos")]
	public static void UnityTest()
	{
		tableau = new int[5] { 12, 10, 35, 90, 23 }; string result = ""; if (!(Deux() == 2)) result += "Exercice 01\n"; if (!(Bonjour() == "bonjour")) result += "Exercice 02\n"; if (!(Double(12) == 24)) result += "Exercice 03\n"; if (!(Ajoute10(9) == 19 && Ajoute10(12) == 22)) result += "Exercice 04\n"; if (!(Fois10Plus5(2) == 25)) result += "Exercice 05\n"; if (!(AjouteDavid("Hello ") == "Hello David")) result += "Exercice 06\n"; if (!(Somme(3, 5) == 8)) result += "Exercice 07\n"; if (!(CharacterSize("12345") == 5 && CharacterSize("123456789") == 9)) result += "Exercice 08\n"; if (!(CharacterCut4("0123456") == "012356" && CharacterCut4("123") == "123")) result += "Exercice 09\n"; if (!(CharacterX("Kacem") == "Xacem")) result += "Exercice 10\n"; if (!(DivisePar2(12.25f) == 6.125f)) result += "Exercice 11\n"; if (!(Racine(289.0f) == 17.0)) result += "Exercice 12\n"; if (!(PlusGrand(11, 41) == 41 && PlusGrand(27, 11) == 27)) result += "Exercice 13\n"; if (!(PlusGrand(12, 33, 21) == 33 && PlusGrand(-12, -33, -21) == -12)) result += "Exercice 14\n"; if (!(SommeListe(10) == 55 && SommeListe(14) == 105)) result += "Exercice 15\n"; if (!(AdditionNbPairs(10) == 30 && AdditionNbPairs(1) == 0 && AdditionNbPairs(7) == 12)) result += "Exercice 16\n"; if (!(NextString("abcd") == "bcde" && NextString("BBBYYY") == "CCCZZZ" && NextString("") == "")) result += "Exercice 17\n"; if (!(TailleTableau(tableau) == 5)) result += "Exercice 18\n"; if (!(SommeTableau(tableau) == 170)) result += "Exercice 19\n"; if (!(MoyenneTableau(tableau) == 34)) result += "Exercice 20\n"; if (!(PlusGrand(tableau) == 90 && PlusGrand(new int[5] { -12, -10, -35, -90, -23 }) == -10)) result += "Exercice 21\n"; if (!(NbVoyelles("Bonjour") == 3 && NbVoyelles("Elephant") == 3 && NbVoyelles("ouiNON") == 4 && NbVoyelles("0UI") == 2)) result += "Exercice 22\n"; if (!(LettreIdentiqueConcecutive("accident") == 1 && LettreIdentiqueConcecutive("aaaabbb") == 5 && LettreIdentiqueConcecutive("d") == 0 && LettreIdentiqueConcecutive("d") == 0)) result += "Exercice 23\n"; if (!(Trier(tableau)[0] == 10 && Trier(tableau)[1] == 12 && Trier(tableau)[2] == 23 && Trier(tableau)[3] == 35 && Trier(new int[4] { 2, 5, 20, -23 })[0] == -23)) result += "Exercice 24\n"; if (!(Fibo(0) == 1 && Fibo(1) == 1 && Fibo(2) == 2 && Fibo(3) == 3 && Fibo(22) == 28657)) result += "Exercice 25\n"; if (!(NbDeux(2) == 1 && NbDeux(-12) == 1 && NbDeux(2322) == 3 && NbDeux(12342) == 2 && NbDeux(222) == 3 && NbDeux(13456789) == 0)) result += "Exercice 26\n"; if (result.Length > 0) Debug.LogError(result); else Debug.Log("Well Job!");
	}

	/////////////////////////////////////////////////////////////////////////////////////////////////
}