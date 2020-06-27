using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using Stock_Alram.WebCrawller;
using Newtonsoft.Json;

namespace Stock_Alram
{
    public partial class Form1 : Form
    {

        const string jsonPath = "subject.json";
        JObject subjectJson = null;
        CrawllManager crallManager = new CrawllManager();


        struct jsonElement
        {
            public int lowCost;
            public int hightCost;
            public int currentCost;
        };

        Dictionary<string, jsonElement> mDictObj = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Initialize(object sender, EventArgs e)
        {
            string jsonFile = Encoding.Default.GetString(File.ReadAllBytes(jsonPath));
            if (jsonFile.Length == 0)
            {
                subjectJson = JObject.Parse("{}");
            }
            else
            {
                subjectJson = JObject.Parse(jsonFile);
            }
            if (subjectJson.Count == 0)
                return;
            mDictObj = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, jsonElement>>(jsonFile);

            for()
        }


        private void Release(object sender, FormClosingEventArgs e)
        {
            File.WriteAllBytes(jsonPath,
                Encoding.Default.GetBytes(subjectJson.ToString()));
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowIcon = false;
                m_notify.Visible = true;
            }
        }

        private void AgainShowForm(object sender, EventArgs e)
        {
            this.Visible = true;
            this.ShowIcon = true;
            m_notify.Visible = false;
        }

        private void CrawllingStock(object sender, EventArgs e)
        {
            if (subjectJson.Count == 0)
                return;
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (mListSubject.FindString(mAddSubject.Text) == ListBox.NoMatches)
            {
                if (crallManager.Add_Sercher(mAddSubject.Text))
                {
                    mListSubject.Items.Add(mAddSubject.Text);

                    jsonElement element = new jsonElement();
                    element.currentCost = crallManager.SubjectCost(mAddSubject.Text);
                    element.lowCost = 0;
                    element.hightCost = 1000000;

                    object boxElement = element;
                    subjectJson.Add(mAddSubject.Text, System.Text.Json.JsonSerializer.Serialize(boxElement));
                    mCurrentCost.Text = element.currentCost.ToString();
                }
            }
            int iSelectIndex = mListSubject.FindString(mAddSubject.Text);
            mListSubject.SetSelected(iSelectIndex, true);

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

    }
}
