<!--
Authors: Owiny Ayorech, Nicolas Tambellini
Date: July, 4 2019
Version: 1.9
Functionality:
-->  
    <?php
    require "includes/header.php";
    ?>

    
<!-- Table with Partners and links to their websites -->
    <section>
        <table id="linkTable" class="table table-dark col-sm-5 ml-3" align="left" border="1" cellpadding="3" cellspacing="0">
        <thead class="thead-light">
            <tr class="d-flex">
                <th class="col-sm-6">Partner</th>
                <th class="col-sm-6">Link</th>
            </tr>
        </thead>
            <?php
            //loop through array and populate table with values
            require "includes/variables.php";
            foreach($travelSites as $k=>$v){
                echo "<tr class='d-flex'>";
                {
                echo "<td class='col-sm-6'>$v</td>";
                echo "<td class='col-sm-6'><a href='".$k."'>".$k."</a></td>";
                }
                echo "</tr>";
            }
            ?>
        </table>
    </section>    
    <?php
        require "includes/footer.php";
    ?>