
package neyapsam;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Users {
    private int id;
    private String name;
    private String password;
    private String location;
    
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
    
    public Users() {
        id = 0;
        name = "Null";
        password = "Null";
        location = "Null";
    }
    
    public Users (int id,String name,String password,String location) {
        this.id = id;
        this.name = name;
        this.password = password;
        this.location = location;
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

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }
}
