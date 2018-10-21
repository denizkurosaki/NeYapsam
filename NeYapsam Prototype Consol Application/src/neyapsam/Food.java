
package neyapsam;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class Food {
    private int id;
    private String name;
    
    private Connection conn;
    String dbUrl = "jdbc:derby://localhost:1527/NeYapsamDatabase";
    String user = "NeYapsam";
    String pass = "NeYapsam!db";

    public Connection connect() {
        try {
            Class.forName("org.apache.derby.jdbc.ClientDriver").newInstance();
            System.out.println("Connection successful");
            conn = DriverManager.getConnection(dbUrl, user, pass);
        } catch (ClassNotFoundException | IllegalAccessException | InstantiationException | SQLException e) {
            System.out.println("Connection error");
        }
        return conn;
    }
    
    public Food() {
        id = 0;
        name = "Null";
    }
    
    public Food(int id,String name) {
        this.id = id;
        this.name = name;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    
    public void properFoodList() {
        if (conn == null) {
            System.out.println("Database is not connected,I am connecting...");
            connect();
        }
        try {
            Statement stmt = conn.createStatement();
            
            Scanner sc = new Scanner(System.in);
            System.out.println("Please enter amount of your ingredients");
            int amount = sc.nextInt();
            String[] arr = new String[amount + 1];
            System.out.println("Please enter your ingredients's names");
            for(int i = 0; i < arr.length; i++) {
                arr[i] = sc.nextLine();
            }
            
            ResultSet rs = stmt.executeQuery("select * from Food");
            System.out.println("fid \t f_name");
            while (rs.next()) {
                System.out.println(rs.getString(1) + "\t" + rs.getString(2));
            }
        } catch (SQLException e) {
        }
    }
}
