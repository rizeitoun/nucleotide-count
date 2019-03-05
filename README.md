# Nucleotide Counter in C#
#### This will count the number of AGCT in a string using System.Linq.  If a non AGCT is used, the function display an error message.

#### Implementation code is NucleotideCount.cs
#### Example tests from exercism where Actual is what code outputs and Expected is the expected answer:
```
        var expected = new Dictionary<char, int>
        {
            ['A'] = 20,
            ['C'] = 12,
            ['G'] = 17,
            ['T'] = 21
        };
        Assert.Equal(expected, NucleotideCount.Count("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"));

```
