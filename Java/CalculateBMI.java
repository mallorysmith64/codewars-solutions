// Language: Java
// Level: 8kyu
// Name of Problem: Calculate BMI

// Instructions: Write function bmi that calculates body mass index (bmi = weight / height ^ 2).

// if bmi <= 18.5 return "Underweight"
// if bmi <= 25.0 return "Normal"
// if bmi <= 30.0 return "Overweight"
// if bmi > 30 return "Obese"

// Solution 1 using pow() and if/else statement:
public class Calculate {
    public static String bmi(double weight, double height) {
     var bmi = weight/Math.pow(height,2);
      if (bmi <= 18.5) {
      return "Underweight";
    } else if (bmi <= 25) {
      return "Normal";
    } else if (bmi <= 30) {
      return "Overweight";
    } else {
      return "Obese";
      }
    }
  }

// Solution 2 using pow() and ternary operator:
public class Calculate {
    public static String bmi(double weight, double height) {
      var bmi = weight/Math.pow(height,2);
    return bmi <= 18.5 ? "Underweight" :
           bmi <= 25.0 ? "Normal" :
           bmi <= 30.0 ? "Overweight" : "Obese";
    }
  }

// Solution 3 using if statements:
public class Calculate {
    public static String bmi(double weight, double height) {
      var bmi = weight/(height*height);
      if(bmi <= 18.5)
        return "Underweight";
      if(bmi <= 25)
        return "Normal";
      if(bmi <= 30)
        return "Overweight";
        return "Obese";
    }
  }

// Sample Tests Passed:
// import org.junit.Test;
// import static org.junit.Assert.assertEquals;
// import org.junit.runners.JUnit4;

// public class SolutionTest {
//     @Test
//     public void testBMI() {
//         assertEquals("Normal", Calculate.bmi(80, 1.80));
//     }
// }