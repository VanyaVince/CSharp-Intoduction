import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class App {


    //int  number;
    int countStairs;

    public static void main(String[] args) {
        boolean flag = true;
        ArrayList<Integer> stair = new ArrayList<>();
        //Stair first = new Stair();
        System.out.println("Enter your number");
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        stair.add(number);


        while (flag) {
            int newStair = 0;
            stair.add(newStair);

            for (int i = 0; i < stair.size() - 1; i++) {

                while (stair.get(i + 1) + 2 < stair.get(i)) {
                    stair.set(i, stair.get(i) - 1);
                    stair.set(i + 1, stair.get(i + 1) + 1);
                }
//                System.out.println(number);
//                System.out.println(newStair);
            }
            if (stair.get(stair.size() - 1) == 0) {
                flag = false;
            }
        }
        for (int i = 0; i < stair.size(); i++) {
            System.out.println(stair.get(i));
        }
        System.out.println(stair.size());
    }
}
