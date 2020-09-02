using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public class Data
{
    public string abbreviation { get; set; }
    public string client_ip { get; set; }
    public string datetime { get; set; }
    public string day_of_week { get; set; }
    public string day_of_year { get; set; }
    public string dst { get; set; }
    public string dst_from { get; set; }
    public string dst_offset { get; set; }
    public string dst_until { get; set; }
    public string raw_offset { get; set; }
    public string timezone { get; set; }
    public string unixtime { get; set; }
    public string utc_datetime { get; set; }
    public string utc_offset { get; set; }
    public string week_number { get; set; }
}

public class Rest : MonoBehaviour
{
    public Text timerText;
    Data data;

    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        while (true)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://worldtimeapi.org/api/ip");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<Data>(json);
            }

            string dateText = data.datetime;

            dateText = dateText.Replace("T", " ").Substring(0, 19);

            timerText.text = dateText;

            yield return new WaitForSeconds(0.1f);
        }
    }
}

