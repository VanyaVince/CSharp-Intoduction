package comDevcolibriDatabase;
//import com.mysql.fabric.jdbc.FabricMySQLDriver;

import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class Main {


    private static final String url = "jdbc:mysql://localhost:3306/mydbtest" +
            "?autoReconnect=true&useSSL=false&useLegacyDatetimeCode=false&serverTimezone=UTC";
    private static final String login = "root";
    private static final String password = "";
    private static final String query = "SELECT * FROM USERS";
    private static List<String> listUsers = new ArrayList<String>();
    private static int count = 1;

    public static void main(String[] args) {

        Users users = new Users();
        Connection connection = null;


        try {
            Driver driver = new com.mysql.cj.jdbc.Driver();
            DriverManager.registerDriver(driver);

//            if (!connection.isClosed()) {
//                System.out.println("We are in");
//            }
//            connection.close();
//            if (connection.isClosed()) {
//                System.out.println("Connection is closed");
//            }

        } catch (SQLException e) {
            System.out.println("Error with finding a driver");
            e.printStackTrace();
        }
        try {
            connection = DriverManager.getConnection(url, login, password);
            Statement statement = connection.createStatement();

            ResultSet resultSet = statement.executeQuery(query);

            while (resultSet.next()){
                users.setId(resultSet.getInt("id"));
                users.setFirstName(resultSet.getString("name"));
                users.setLastName(resultSet.getString("age"));
                users.setEmail(resultSet.getString("email"));

                listUsers.add(users.getFirstName());

//                System.out.println(users);
            }
//            statement.execute("INSERT INTO users(name, age, email) VALUES ('Sergio', 42, 'sergio@mail.ru');");
//            int result = statement.executeUpdate("UPDATE users SET name = 'Amalia' WHERE id = 6;");
//            System.out.println(result);

//            statement.addBatch("INSERT INTO users(name, age, email) VALUES ('Michael-1 ', 41, 'michael@mail.ru');");
//            statement.addBatch("INSERT INTO users(name, age, email) VALUES ('Michael-2 ', 42, 'michael@mail.ru');");
//            statement.addBatch("INSERT INTO users(name, age, email) VALUES ('Michael-3 ', 43, 'michael@mail.ru');");
//
//            statement.executeBatch();

//            statement.clearBatch();
//            ResultSet rs = statement.executeQuery("SELECT * FROM USERS");

//            System.out.println(connection.isClosed());
        } catch (SQLException e) {
            e.printStackTrace();
        }
        for (String user: listUsers){
            System.out.println(count +") "+ user);
            count++;
        }
    }
}
