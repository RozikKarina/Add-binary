using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder result = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        // Traverse both strings from the end
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            // Add a's current digit if present
            if (i >= 0) sum += a[i--] - '0';

            // Add b's current digit if present
            if (j >= 0) sum += b[j--] - '0';

            // Append the current bit to the result
            result.Append(sum % 2);

            // Calculate the carry for the next iteration
            carry = sum / 2;
        }

        // Since we append to result in reverse order, reverse it before returning
        char[] resultArray = result.ToString().ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}
