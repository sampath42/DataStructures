using System.Linq;
using System.Collections.Generic;

namespace CustomDictionary
{
    public class CustomKeyValuePair<TKey,TValue>
    {
        public TKey Key{get;set;}
        public TValue Value{get;set;}
    }
    public class CustomDictionary<TKey,TValue>
    {
        private List<CustomDictionary<TKey,TValue>> _customDictionaryData = new List<CustomDictionary<TKey,TValue>>();

        public TKey Key{get;set;}
        public TValue Value{get;set;}

        public CustomDictionary(TKey key,TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public CustomDictionary()
        {
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;            
                while(index < _customDictionaryData.Count) 
                {
                    if (Keys[index].Equals(key)) 
                    {
                        return Values[index];
                    }
                    index++;
                }
                throw new System.Exception("Key does not exists");
                //return _customDictionaryData.Where(item=>item.Key.Equals(key)).Single().Value;                
            }
            set
            {
                int index = 0;            
                bool isKeyExists = false;                
                while(index < _customDictionaryData.Count) 
                {
                    if (Keys[index].Equals(key)) 
                    {
                        Values[index] = value; 
                        isKeyExists = true;                       
                    }
                    index++;
                }
                if(!isKeyExists)
                {
                    throw new System.Exception("Key does not exists");
                }
                //_customDictionaryData.ForEach(item=>{if(item.Key.Equals(key)){item.Value=value;}});
            }
        }        

        public TKey[] Keys {get;set;}
        public TValue[] Values {get;set;}

        public void Add(TKey key,TValue value)
        {            
            if(Keys !=null && Keys.Any(k=>key.Equals(key)))
            {
                throw new System.Exception("Key already exists");
            }
            Keys.Append(key);
            Values.Append(value);
            _customDictionaryData.Add(new CustomDictionary<TKey,TValue>(key,value));
        }
    }
}