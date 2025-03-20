using System.Collections.Generic;
using System.Linq;
namespace BinaNavigasyonSistemi
{
    public static class KuyruksuzDijstraAlgoritmasi
    {
        public static List<int> DijkstraAlgoritmasi(double[,] GrafMatrisi, int kaynakDugum, int hedefDugum)
        {
            var n = GrafMatrisi.GetLength(0);
            double[] mesafeDizisi = new double[n];
            for (int i = 0; i < n; i++)
            {
                mesafeDizisi[i] = int.MaxValue;
            }
            mesafeDizisi[kaynakDugum] = 0;
            var used = new bool[n];
            var previous = new int?[n];
            while (true)
            {
                double minimumMesafe = int.MaxValue;
                var minNode = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!used[i] && minimumMesafe > mesafeDizisi[i])
                    {
                        minimumMesafe = mesafeDizisi[i];
                        minNode = i;
                    }
                }
                if (minimumMesafe == int.MaxValue)
                {
                    break;
                }
                used[minNode] = true;
                for (int i = 0; i < n; i++)
                {
                    if (GrafMatrisi[minNode, i] > 0)
                    {
                        var shortestToMinNode = mesafeDizisi[minNode];
                        var distanceToNextNode = GrafMatrisi[minNode, i];
                        var toplamMesafe = shortestToMinNode + distanceToNextNode;
                        if (toplamMesafe < mesafeDizisi[i])
                        {
                            mesafeDizisi[i] = toplamMesafe;
                            previous[i] = minNode;
                        }
                    }
                }
            }
            if (mesafeDizisi[hedefDugum] == int.MaxValue)
            {
                return null;
            }
            var path = new LinkedList<int>();
            int? aktifDugum = hedefDugum;
            while (aktifDugum != null)
            {
                path.AddFirst(aktifDugum.Value);
                aktifDugum = previous[aktifDugum.Value];
            }
            return path.ToList();
        }
    }
}
