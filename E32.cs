namespace WinGost
{
    /// <summary>
    /// Шифратор
    /// </summary>
    class E32 : Converter
    {
        readonly byte[] _encrByteFile;
        readonly uint[] _uintKey;
        ulong[] _ulongFile;

        private E32() { }

        public E32(byte[] file, byte[] key)
        {
            _uintKey = GetUIntKeyArray(key);
            _ulongFile = GetULongDataArray(file);

            _encrByteFile = ConvertToByte(EncryptFile());
        }

        public byte[] GetEncryptFile
        {
            get { return _encrByteFile; }
        }

        private ulong[] EncryptFile()
        {
            BasicStep[] K = new BasicStep[8];
            ulong[] ulongEncrFile = new ulong[_ulongFile.Length];
            
            for (int k = 0; k < _ulongFile.Length; k++)
            {
                ulongEncrFile[k] = _ulongFile[k];

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < K.Length; i++)
                    {
                        K[i] = new BasicStep(ulongEncrFile[k], _uintKey[i]);
                        ulongEncrFile[k] = K[i].BasicEncrypt(false);
                    }
                }

                for (int i = K.Length - 1; i >= 0; i--)
                {
                    K[i] = new BasicStep(ulongEncrFile[k], _uintKey[i]);

                    if (i != 0)
                        ulongEncrFile[k] = K[i].BasicEncrypt(false);
                    else
                        ulongEncrFile[k] = K[i].BasicEncrypt(true);
                }
            }

            return ulongEncrFile;
        }
    }
}