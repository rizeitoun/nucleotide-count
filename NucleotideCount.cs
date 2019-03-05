using System;
using System.Linq;
using System.Collections.Generic;

// Basic nucleotide counter using Linq.

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var seq_count = new Dictionary<char, int>
            {
                { 'A', 0 },
                { 'T', 0 },
                { 'G', 0 },
                { 'C', 0 }
            };

        string sequnce_upper = sequence.ToUpper();
        HashSet<char> input_char = new HashSet<char>(sequnce_upper);

        foreach (char key in input_char)
        {
            if (seq_count.ContainsKey(key))
            {
                seq_count[key] += sequnce_upper.Count(f => f == key);
            }
            else
            {
                throw new ArgumentException(String.Format("{0} is not a valid nucleotide", key));
            }
        }

        return seq_count;
    }
}
