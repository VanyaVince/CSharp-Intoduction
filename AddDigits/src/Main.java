public class Main {
    public static void main(String[] args) {

        System.out.println(addDigits(2999));
    }

    private static int addDigits(int num) {
        int summary = num;

        while (summary >= 10) {
            summary = sumUp(summary);
        }
        return summary;
    }

    private static int sumUp (int number) {
        int count = 0;
        String [] numericArray = String.valueOf(number).split("");
        for (int i = 0; i < numericArray.length; i++) {
            count += Integer.parseInt(numericArray[i]);
        }
        return count;
    }

}
