<?php
$servername = "mysql.hostinger.com.br";
$username = "u695866113_root";
$password = "Senha@88";
$dbname = "u695866113_rpgjv";

// Create connection
$conn = mysqli_connect($servername, $username, $password, $dbname);
// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

if($_POST["Service"] == "Save")
{
	$sql = "SELECT * FROM `Save` WHERE `User`='" . $_POST["User"] . "'";
	$result = mysqli_query($conn, $sql);

	if (mysqli_num_rows($result) > 0) {
		//JA EXISTE USUARIO
		echo "TEM USUARIO";
	} else {
		//NAO EXISTE
		$sql = "INSERT INTO `Save` (`user`)
		VALUES ('" . $_POST["User"] . "')";
		if (mysqli_query($conn, $sql)) {
			echo "Record updated successfully";
		} else {
			echo "Error updating record: " . mysqli_error($conn);
		}
	}


	$sql = "UPDATE Save SET " .

	"`Nivel`=" . $_POST["Nivel"] . ", " .
	"`Lvl_Max`=" . $_POST["Lvl_Max"] . ", " .
	"`STR`=" . $_POST["STR"] . ", " .
	"`DEX`=" . $_POST["DEX"] . ", " .
	"`CON`=" . $_POST["CON"] . ", " .
	"`INT`=" . $_POST["INT"] . ", " .
	"`LUK`=" . $_POST["LUK"] . ", " .
	"`Atributos`=" . $_POST["Atributos"] . ", " .
	"`FIRE`=" . $_POST["FIRE"] . ", " .
	"`EXPL`=" . $_POST["EXPL"] . ", " .
	"`HEAL`=" . $_POST["HEAL"] . ", " .
	"`DOUBLE`=" . $_POST["DOUBLE"] . ", " .
	"`REVENGE`=" . $_POST["REVENGE"] . ", " .
	"`LIFE`=" . $_POST["LIFE"] . ", " .
	"`Skill_P`=" . $_POST["Skill_P"] . ", " .
	"`XP`=" . $_POST["XP"] . 

	" WHERE `User`='" . $_POST["User"] . "'";

	echo "  " . $sql . "  ";

	if (mysqli_query($conn, $sql)) {
		echo "Record updated successfully";
	} else {
		echo "Error updating record: " . mysqli_error($conn);
	}
}
else if($_POST["Service"] == "Load")
{
	$sql = "SELECT * FROM Save WHERE `User`='" . $_POST["User"] . "'";
	$result = mysqli_query($conn, $sql);

	if (mysqli_num_rows($result) > 0) {
		while($row = mysqli_fetch_assoc($result)) {
			echo "Nivel=" . $row["Nivel"]. ";XP=" . $row["XP"]. ";Lvl_Max=" . $row["Lvl_Max"]. ";STR=" . $row["STR"]. ";DEX=" . $row["DEX"]. ";CON=" . $row["CON"]. ";INT=" . $row["INT"]. ";LUK=" . $row["LUK"]. ";Atributos=" . $row["Atributos"]. ";FIRE=" . $row["FIRE"]. ";EXPL=" . $row["EXPL"]. ";HEAL=" . $row["HEAL"]. ";DOUBLE=" . $row["DOUBLE"]. ";REVENGE=" . $row["REVENGE"]. ";LIFE=" . $row["LIFE"]. ";Skill_P=" . $row["Skill_P"]. ";";
		}
	} else {
		echo "error";
	}
}

mysqli_close($conn);
?>