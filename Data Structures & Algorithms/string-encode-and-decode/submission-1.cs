public class Solution {
    public string Encode(IList<string> strs) {
        var ans = new StringBuilder();

        foreach (var str in strs) {
            ans.Append(str.Length.ToString() + "#" + str);
        }
        Console.WriteLine("string is "+ans.ToString());
        return ans.ToString();
    }

    public List<string> Decode(string s) {
        var ans = new List<string>();
        int i = 0;

        while (i < s.Length) {

            int c=i;

            while(s[c]!='#')
            c++;

            int n = int.Parse(s.Substring(i,c-i));
            
            ans.Add(s.Substring(c+1,n));

            i=c+1+n;


        }

        return ans;
    }
}
