namespace GenericsIntro
{
    class MyDictionary<K, V>
    {
        K[] diziAnahtar;

        V[] diziDeger;

        
        public MyDictionary()
        {
            diziAnahtar = new K[0];
            diziDeger = new V[0];

        }
        public void Add(K anahtar, V değer)
        {
            K[] tempKey = diziAnahtar;
            V[] tempValue = diziDeger;

            diziAnahtar = new K[tempKey.Length + 1];
            diziDeger = new V[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                diziAnahtar[i]= tempKey[i];
                diziDeger[i]= tempValue[i];


            }
            diziAnahtar[diziAnahtar.Length - 1] = anahtar;
            diziDeger[diziDeger.Length - 1] = değer;

            

        }





    }
}
