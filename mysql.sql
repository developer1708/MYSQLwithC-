-- --------------------------------------------------------
-- Хост:                         127.0.0.1
-- Версия сервера:               10.1.26-MariaDB - mariadb.org binary distribution
-- Операционная система:         Win32
-- HeidiSQL Версия:              11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Дамп данных таблицы student.marks: ~0 rows (приблизительно)
/*!40000 ALTER TABLE `marks` DISABLE KEYS */;
/*!40000 ALTER TABLE `marks` ENABLE KEYS */;

-- Дамп данных таблицы student.student_table: ~7 rows (приблизительно)
/*!40000 ALTER TABLE `student_table` DISABLE KEYS */;
REPLACE INTO `student_table` (`ID`, `Name`, `University`, `Adres`, `Telefon`, `CreateAt`) VALUES
	(1, 'Samadov Rauf', 'TGU', 'Gafurov', '000034101', '2022-05-11 12:36:10'),
	(3, 'Azizbek Nosirov', 'Hgu', 'Gafurov', '943893754387', '2022-05-11 13:33:28'),
	(4, 'Sharifjon Sobirov', 'Hgu', 'Asht', '929254321', '2022-05-11 13:42:59'),
	(5, 'Anvar Nosirov', 'Politech', 'Istaravshan', '918232322', '2022-05-11 17:26:29'),
	(6, 'Shohruh Rustamov', 'TGUKA', 'Isfara', '918342322', '2022-05-11 17:26:29'),
	(7, 'Maruf Rustamov', 'TGU', 'Konibodom', '912322322', '2022-05-11 17:27:12'),
	(8, 'Izzatullo Azimov', 'HGU', 'Isfara', '923344544', '2022-05-11 17:27:57');
/*!40000 ALTER TABLE `student_table` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
