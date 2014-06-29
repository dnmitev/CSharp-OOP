namespace DocumentSystem
{
    using System;
    using System.Linq;

    public abstract class EncryptableBinaryDocument : BinaryDocument, IEncryptable
    {
        private bool isEncryped;

        public EncryptableBinaryDocument()
        {
            this.isEncryped = false;
        }

        public bool IsEncrypted
        {
            get
            {
                return this.isEncryped;
            }
        }

        public void Encrypt()
        {
            this.isEncryped = true;
        }

        public void Decrypt()
        {
            this.isEncryped = false;
        }

        public override string ToString()
        {
            if (this.isEncryped)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }

            return base.ToString();
        }
    }
}