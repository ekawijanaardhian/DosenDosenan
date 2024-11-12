using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosenDosenan
{
    internal class DosenTetap : Dosen
    {


        private int mTunjanganFungsional = 300000;

        public DosenTetap(int mHonorPerSKS, int mJumlahSKS, string mNama, int mNID, String mStatus) : base(mHonorPerSKS, mJumlahSKS, mNama, mNID, mStatus)
        {

        }

        public int MTunjanganFungsional { get => mTunjanganFungsional; set => mTunjanganFungsional = value; }

        public int tunjanganFungsional() {
             return mTunjanganFungsional;
        }

        public override float TotalBayar() {
            return (MHonorPerSKS * MJumlahSKS) + tunjanganFungsional();
        }

        public override float PPH()
        {
            return (float)(0.1 * TotalBayar());
        }

        public float pendapatanBersih() {
            return TotalBayar() - PPH();
        }
    }
}
