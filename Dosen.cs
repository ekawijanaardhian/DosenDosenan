using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosenDosenan
{
    internal class Dosen
    {
        private int mHonorPerSKS;
        private int mJumlahSKS;
        private String mNama;
        private int mNID;
        private String mStatus;

        public Dosen(int mHonorPerSKS, int mJumlahSKS, string mNama, int mNID, String mStatus)
        {
            this.mHonorPerSKS = mHonorPerSKS;
            this.mJumlahSKS = mJumlahSKS;
            this.mNama = mNama;
            this.mNID = mNID;
            this.mStatus = mStatus;
        }

        public int MHonorPerSKS { get => mHonorPerSKS; set => mHonorPerSKS = value; }
        public int MJumlahSKS { get => mJumlahSKS; set => mJumlahSKS = value; }
        public string MNama { get => mNama; set => mNama = value; }
        public int MNID { get => mNID; set => mNID = value; }
        public String MStatus { get => mStatus; set => mStatus = value; }


        public virtual float TotalBayar() {
            return mHonorPerSKS * mJumlahSKS;
        }
        public virtual float PPH() {
            return 5 / 100 * TotalBayar();
        }
    }
}
