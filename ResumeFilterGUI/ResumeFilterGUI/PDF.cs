using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ResumeFilterGUI
{
    public class Resume
    {
        public string path;
        public string name;
        public List<string> keyWordsContained;
        public List<string> keyWordsNotContained;
        public bool pass;
        public bool PDF;

        public Resume(string _path, bool _PDF)
        {
            path = _path;
            PDF = _PDF;
            name = System.IO.Path.GetFileNameWithoutExtension(path);
            keyWordsContained = new List<string>();
            keyWordsNotContained = new List<string>();
        }

        public string ExtractTextFromPdf()
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }

        public string ExtractTextFromWord()
        {
            Stream stream = File.Open(path, FileMode.Open);
            WordprocessingDocument wpD = WordprocessingDocument.Open(stream, true);
            Body body = wpD.MainDocumentPart.Document.Body;
            stream.Close();
            return body.InnerText;
        }

        public void ResumeContainsKeyWords(List<string> requiredKeyWords, List<string> optionalKeyWords)
        {
            string contents;
            if (PDF)
                contents = this.ExtractTextFromPdf();
            else
                contents = this.ExtractTextFromWord();

            pass = true;
            foreach (string s in requiredKeyWords)
            {
                if (!contents.ToLower().Contains(s.ToLower()))
                {
                    pass = false;
                    keyWordsNotContained.Add(s);
                }
                else
                    keyWordsContained.Add(s);
            }

            foreach (string s in optionalKeyWords)
            {
                if (!contents.ToLower().Contains(s.ToLower()))
                    keyWordsNotContained.Add(s);
                else
                    keyWordsContained.Add(s);
            }
        }
    }
}
