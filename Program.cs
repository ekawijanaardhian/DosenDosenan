using DosenDosenan;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        //int mHonorPerSKS, int mJumlahSKS, string mNama, int mNID, int mStatus
        DosenTetap dosenTetap1 = new DosenTetap(78000,12,"Usep Benta",0412098701,"Dosen Tetap");
        DosenTetap dosenTetap2 = new DosenTetap(88000, 12, "Asep Peureum", 0414098909, "Dosen Tetap");
        DosenTetap dosenTetap3 = new DosenTetap(78000, 12, "Ujang Cimot", 0411028804, "Dosen Tetap");
        DosenTetap dosenTetap4 = new DosenTetap(78000, 12, "Usep Benta", 0412088202, "Dosen Tetap");
        ArrayList arrayList = new ArrayList();
        arrayList.Add(dosenTetap1);
        arrayList.Add(dosenTetap2);
        arrayList.Add(dosenTetap3);
        arrayList.Add(dosenTetap4);

        Hashtable hashtable = new Hashtable();
        hashtable.Add("D1", dosenTetap1);
        hashtable.Add("D2", dosenTetap2);
        hashtable.Add("D3", dosenTetap3);
        hashtable.Add("D4", dosenTetap4);


        Console.WriteLine("Dosen Dosenan ..........");
        Console.WriteLine("List Dosen Tetap versi Array List");
        Console.WriteLine("No : Nama : Total Bayar : PPH    : Pendapatan Bersih");

        for (int i = 0; i < arrayList.Count; i++)
        {
            DosenTetap dosenTetap = (DosenTetap)arrayList[i];
            Console.WriteLine(i + 1 + " : " + dosenTetap.MNama + " : " +dosenTetap.TotalBayar() + " : " + dosenTetap.PPH() + " : " + dosenTetap.pendapatanBersih() );

        }

        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("List Dosen Tetap versi Hash Table");
        Console.WriteLine("No : Nama : Total Bayar : PPH    : Pendapatan Bersih");

        IDictionaryEnumerator enumerator = hashtable.GetEnumerator();

        while (enumerator.MoveNext()) {
            DosenTetap dosenTetap = (DosenTetap)enumerator.Value;
            Console.WriteLine(enumerator.Key + " : " + dosenTetap.MNama + " : " + dosenTetap.TotalBayar() + " : " + dosenTetap.PPH() + " : " + dosenTetap.pendapatanBersih());
      
        }


    }
}