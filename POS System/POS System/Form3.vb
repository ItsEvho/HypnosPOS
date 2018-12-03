Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("You need support?

Don't worry! Everyone needs support at some point.

Call our 24/7 365 days a year support line and they'll help you right out!

Number: 888-635-6274 (Totally not a Microsoft Tech Support Scammer Number! :wink:)

Also quote this code: " + Guid.NewGuid.ToString)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Potato")
        ComboBox1.Items.Add("Sweetcorn")
        ComboBox1.Items.Add("Carrot")
        ComboBox1.Items.Add("Broccoli")
        ComboBox1.Items.Add("Green Bean")
        ComboBox1.Items.Add("Tomato")
        ComboBox1.Items.Add("Garlic")
        ComboBox1.Items.Add("Cucumber")
        ComboBox1.Items.Add("Spinach")
        ComboBox1.Items.Add("Onion")
        ComboBox1.Items.Add("Sweet Potato")
        ComboBox1.Items.Add("Mushroom")
        ComboBox1.Items.Add("Pea")
        ComboBox1.Items.Add("Asparagus")
        ComboBox1.Items.Add("Cauliflower")
        ComboBox1.Text = "Vegetables"

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Strawberry")
        ComboBox2.Items.Add("Watermelon")
        ComboBox2.Items.Add("Grape")
        ComboBox2.Items.Add("Orange")
        ComboBox2.Items.Add("Peache")
        ComboBox2.Items.Add("Banana")
        ComboBox2.Items.Add("Mango")
        ComboBox2.Items.Add("Pineapple")
        ComboBox2.Items.Add("Apple")
        ComboBox2.Items.Add("Cherry")
        ComboBox2.Items.Add("Blueberry")
        ComboBox2.Items.Add("Raspberry")
        ComboBox2.Items.Add("Pear")
        ComboBox2.Items.Add("Blackberry")
        ComboBox2.Items.Add("Plum")
        ComboBox2.Text = "Fruit"

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Sourdough")
        ComboBox3.Items.Add("Garlic Bread")
        ComboBox3.Items.Add("Pumpernickel")
        ComboBox3.Items.Add("Rye Bread")
        ComboBox3.Items.Add("Boule")
        ComboBox3.Items.Add("Marble Rye")
        ComboBox3.Items.Add("Ciabatta")
        ComboBox3.Items.Add("Challah")
        ComboBox3.Items.Add("Focaccia")
        ComboBox3.Items.Add("French Baguette")
        ComboBox3.Items.Add("Brioche")
        ComboBox3.Items.Add("Multigrain")
        ComboBox3.Items.Add("50/50")
        ComboBox3.Items.Add("White Bread")
        ComboBox3.Items.Add("Brown Bread")
        ComboBox3.Text = "Bread"

        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("Pork")
        ComboBox4.Items.Add("Fish")
        ComboBox4.Items.Add("Chicken")
        ComboBox4.Items.Add("Beef")
        ComboBox4.Items.Add("Goat")
        ComboBox4.Items.Add("Duck")
        ComboBox4.Items.Add("Rabbit")
        ComboBox4.Items.Add("Foal")
        ComboBox4.Items.Add("Turkey")
        ComboBox4.Items.Add("Ham")
        ComboBox4.Items.Add("Bacon")
        ComboBox4.Items.Add("Black Pudding")
        ComboBox4.Items.Add("Yorkshire Sausage")
        ComboBox4.Items.Add("Norfolk Sausage")
        ComboBox4.Items.Add("Suffolk Sausage")
        ComboBox4.Text = "Meat"

        ComboBox5.Items.Clear()
        ComboBox5.Items.Add("Georgia Peach Pie")
        ComboBox5.Items.Add("Arctic Roll")
        ComboBox5.Items.Add("Chocolate Log")
        ComboBox5.Items.Add("Pineapple Upside-Down Cake")
        ComboBox5.Items.Add("Jelly & Ice Cream")
        ComboBox5.Items.Add("Bread & Butter Pudding")
        ComboBox5.Items.Add("Sticky Toffee Pudding")
        ComboBox5.Items.Add("Chocolate Brownie")
        ComboBox5.Items.Add("Victoria Sponge")
        ComboBox5.Items.Add("Apple Crumble")
        ComboBox5.Items.Add("Rhubarb Crumble")
        ComboBox5.Items.Add("Chocolate Sponge with Custard")
        ComboBox5.Items.Add("Jam Roly-Poly")
        ComboBox5.Items.Add("Angel Delight")
        ComboBox5.Items.Add("Ginger Cake")
        ComboBox5.Text = "Desserts"

    End Sub
End Class