

namespace exercices;

public class Exercices
{
    public string AffichePrix(int nbre, decimal pU, int taxe)
    {
        decimal prixTTC = CalculPrix(nbre, pU, taxe);
        return $"{nbre} articles à {pU} et taxe à {taxe} % - {Math.Round(prixTTC, 2)}";

        static decimal CalculPrix(int nbre, decimal pU, int taxe)
        {
            decimal prixHT = nbre * pU;
            decimal prixTTC = prixHT + (prixHT * taxe / 100);

            if (prixHT >= 1000 && prixHT < 5000)
            {
                prixTTC -= (prixTTC * 3 / 100);
            }

            if (prixHT >= 5000)
            {
                prixTTC -= (prixTTC * 5 / 100);
            }

            return prixTTC;
        }
    }
}
