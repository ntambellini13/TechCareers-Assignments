    <?php
    require "includes/header.php";
    ?>
    <section>
        <table id="linkTable" class="link-table table table-dark col-2 ml-3" align="left" border="1" cellpadding="3" cellspacing="0">
        <th class="thead-light">Row</th><th>Page Link</th>
            <?php
            for($i=1;$i<=6;$i++)
            {
            echo "<tr>";
            {
            echo "<td>$i</td>";
            echo "<td><a href='links/page" . $i . ".php'>page" . $i."</a></td>";
            }
            echo "</tr>";
            }
            ?>
        </table>
        </section>    
    <?php
        require "includes/footer.php";
      ?>