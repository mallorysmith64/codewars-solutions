// Language: Javascript
// Level: 8kyu
// Name of Problem: DNA to RNA Conversion

// Instructions: Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. 
// It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').
// Ribonucleic acid, RNA, is the primary messenger molecule in cells. 
// RNA differs slightly from DNA its chemical structure and contains no Thymine. 
// In RNA Thymine is replaced by another nucleic acid Uracil ('U').

// Create a function which translates a given DNA string into RNA.
// The input string can be of arbitrary length - in particular, it may be empty. 
// All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.

// Example:
// DNAtoRNA("GCAT") returns ("GCAU")

// Solution 1 using replace():
function DNAtoRNA(dna) {
    return dna.replace(/t/gi, 'U')
  }

// Solution 2 using split() and join():
function DNAtoRNA(dna) {
    return dna.split('T').join('U')
  }

// Sample Tests Passed:
// Test.assertEquals(DNAtoRNA("TTTT"), "UUUU")
// Test.assertEquals(DNAtoRNA("GCAT"), "GCAU")
// Test.assertEquals(DNAtoRNA("GACCGCCGCC"), "GACCGCCGCC")