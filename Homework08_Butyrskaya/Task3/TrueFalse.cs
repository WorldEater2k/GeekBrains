using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task3
{
    [Serializable]
    public class Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }

    class TrueFalse
    {
        string _fileName;
        List<Question> _list;
        public string FileName { set => _fileName = value; }
        public int Count { get => _list.Count; }
        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            _list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (_list != null && index < _list.Count && index >= 0)
                _list.RemoveAt(index);
        }
        public Question this[int index]
        {
            get { return _list[index]; }
        }
        public void SaveXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, _list);
            fStream.Close();
        }
        public void LoadXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _list = xmlFormat.Deserialize(fStream) as List<Question>;
            fStream.Close();
        }
    }
}