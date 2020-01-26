// Language: Java
// Level: 8kyu
// Name of Problem: DNA to RNA Conversion

// Instructions: Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
// Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').
// Create a function which translates a given DNA string into RNA.
// The input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

// Example:
// new Bio().dnaToRna("GCAT") // returns "GCAU"

// Solution 1:
public class Bio {
    public String dnaToRna(String dna) {
        return dna.replace('T','U');
    } 
}

// Sample Tests Passed:
// import org.junit.Test;
// import static org.junit.Assert.assertEquals;

// public class BioTest {
//     @Test
//     public void testDna() throws Exception {
//         Bio b = new Bio();
//         assertEquals("UUUU", b.dnaToRna("TTTT"));
//     }
    
//     @Test
//     public void testDna2() throws Exception {
//         Bio b = new Bio();
//         assertEquals("GCAU", b.dnaToRna("GCAT"));
//     }
// }