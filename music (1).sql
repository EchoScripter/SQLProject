-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 18, 2024 at 03:47 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `music`
--

-- --------------------------------------------------------

--
-- Table structure for table `albums`
--

CREATE TABLE `albums` (
  `ID` int(11) NOT NULL,
  `ALBUM_TITLE` varchar(100) NOT NULL,
  `ARTIST` varchar(100) NOT NULL,
  `YEAR` int(11) NOT NULL,
  `IMAGE_NAME` varchar(1000) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `albums`
--

INSERT INTO `albums` (`ID`, `ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES
(1, 'Abbey Road', 'The Beatles', 1969, 'https://upload.wikimedia.org/wikipedia/en/thumb/4/42/Beatles_-_Abbey_Road.jpg/220px-Beatles_-_Abbey_Road.jpg', 'Abbey Road is the eleventh studio album by the English rock band the Beatles, released on 26 September 1969. It is the last album the group recorded,[2] although Let It Be was the last album completed before the band\'s break-up in April 1970.[3] It was mostly recorded in April, July, and August 1969, and topped the record charts in both the United States and the United Kingdom. A double A-side single from the album, \"Something\" / \"Come Together\", was released in October, which also topped the charts in the US.'),
(2, 'Help!', 'The Beatles', 1965, 'https://upload.wikimedia.org/wikipedia/en/thumb/e/e7/Help%21_%28The_Beatles_album_-_cover_art%29.jpg/220px-Help%21_%28The_Beatles_album_-_cover_art%29.jpg', 'Help! is the fifth studio album by the English rock band the Beatles and the soundtrack to their film of the same name. It was released on 6 August 1965 by Parlophone. Seven of the fourteen songs, including the singles \"Help!\" and \"Ticket to Ride\", appeared in the film and take up the first side of the vinyl album. The second side includes \"Yesterday\", the most-covered song ever written.[3] The album was met with favourable critical reviews and topped the Australian, German, British and American charts.'),
(3, 'Revolver', 'The beatles', 1966, 'https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Revolver_%28album_cover%29.jpg/220px-Revolver_%28album_cover%29.jpg', 'Revolver is the seventh studio album by the English rock band the Beatles. It was released on 5 August 1966, accompanied by the double A-side single \"Eleanor Rigby\" / \"Yellow Submarine\". The album was the Beatles\' final recording project before their retirement as live performers and marked the group\'s most overt use of studio technology to date, building on the advances of their late 1965 release Rubber Soul. It has since become regarded as one of the greatest and most innovative albums in the history of popular music, with recognition centred on its range of musical styles, diverse sounds and lyrical content.'),
(4, 'X', 'Ed Sheeran', 2014, 'https://upload.wikimedia.org/wikipedia/en/thumb/a/ad/X_cover.png/220px-X_cover.png', '× (\"Multiply\") is the second studio album by English singer-songwriter, Ed Sheeran. It was released on 20 June 2014 in Australia and New Zealand,[3] and worldwide on 23 June through Asylum Records and Atlantic Records.[4] The album received positive reviews from music critics. It was an international commercial success, peaking at No. 1 in 15 countries, while topping both the UK Albums Chart and the US Billboard 200. × also reached the top five in seven other countries and was the best selling album of 2014 in Australia, New Zealand, Ireland, and the United Kingdom. Five singles were released from the album: \"Sing\", \"Don\'t\", \"Thinking Out Loud\", \"Bloodstream\" (a collaboration with Rudimental), and \"Photograph\".[5][6][7]'),
(5, 'Black', 'Black', 2009, 'https://upload.wikimedia.org/wikipedia/en/thumb/0/0a/Black_bangladeshi_band_album.jpg/220px-Black_bangladeshi_band_album.jpg', 'Black is the fourth studio album by Bangladeshi rock band Black. In 2009 Black announced on their official Facebook page that they had started to work on their fourth studio album and it would be a self-titled album. Work on the album properly started after Rafiqul Ahsan Titu (ex-Aashor) joined the band as the permanent bass player after Shahriar Shagor left the band. Black stated, they had plans to release the album on the Eid-ul-Azha of 2010, but due to other commitments of the band members and tight scheduling they were unable to succeed. After a few more changes of speculated release dates the band finally announced the official release date, August 21, 2011.[1][2] According to the band, the album contains the heaviest possible music they have yet made. The first single off the album was \"Aajo...\", its music video premiered at YouTube in September 2011.[3]'),
(6, '(\"Divide\")', 'Ed Sheeran', 2017, 'https://upload.wikimedia.org/wikipedia/en/thumb/4/45/Divide_cover.png/220px-Divide_cover.png', '÷ (\"Divide\") is the third studio album by English singer-songwriter Ed Sheeran. It was released on 3 March 2017 through Asylum Records and Atlantic Records. \"Castle on the Hill\" and \"Shape of You\" were released as the album\'s lead singles on 6 January 2017. The album won the Grammy Award for Best Pop Vocal Album at the 60th Annual Grammy Awards.[1][2] As of March 2024, the deluxe version of the album is the second most streamed album of all time on Spotify.[3]'),
(15, 'random', 'abcd', 2000, 'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEABsbGxscGx4hIR4qLSgtKj04MzM4PV1CR0JHQl2NWGdYWGdYjX2Xe3N7l33gsJycsOD/2c7Z//////////////8BGxsbGxwbHiEhHiotKC0qPTgzMzg9XUJHQkdCXY1YZ1hYZ1iNfZd7c3uXfeCwnJyw4P/Zztn////////////////CABEIAMUBPAMBIgACEQEDEQH/xAAaAAACAwEBAAAAAAAAAAAAAAAAAQIDBAUG/9oACAEBAAAAAPNiJCYwJSGJwTTlECDSA6JhikSBhL03nIyH0CPOAcooINRATGgYTRu08tsehaOaX0OcYhBqKaTGgkE47fR8XmTa3SKMp1ebGcYBXJQBJjAkE9nYx8ayZZCdtFmfo4zvee2Y4VSUBEWMZILOhf0uBTca4UaMlr38a+FmnmlTUBJMbCYWW69fHs6uDec7tcK2jRl0QszQdU7cpGIEpMmK3v8APy06pXbpcyyi7PbmsLKIa6LclBCIiywVqV+kqo1z1bVzoO7NZGBONGmmeGKnnUVdaRusmpTcbpbdtObLO/LLTli55IRVaNGEjVde3qsrsndHWVa9mePPnqxG/LCRnqnHPK7BF0U9iVs+ngnbK6naUabKiirRlWyqq4optKLssZVW8zpls9+Gc52Vaiq+UCqq6iOqFVxTTcZ7cNlsLsXEk9s46KZ6FuKNerMsEteFdDLXOWeqyvCs8pPPEbLtCrdtmuVezXTRknfkW3JTbZlupzZ1YqNWNJssZOHXsz2R0bY4K3fmjdnpttyzeOpWUBEjJuUhx2Tzarb+hDmRL80NGWi6R0eJXWRBADbbcdfR4+q67oxwyxacm+nP2+A4meEXEEDTGyXf42/mdC2G6eIwasfQymeTpiooQIGA2NSlHWT32YaK781sJ0EYEQSYgYiQNSasnPcZ8y0ZpJVkRIBAA0DYDamzVVLOa', 'abcdads'),
(17, 'Abar', 'Black', 2008, 'https://upload.wikimedia.org/wikipedia/en/thumb/2/23/Black_abar_1.jpg/220px-Black_abar_1.jpg', 'আবার (Again) is the third studio album by Bangladeshi rock band Black, released on July 10, 2008.[1] After a full five-year hiatus the band released the album under the sponsorship of Warid Telecom.[2] A gala was held for the album\'s release at Dhaka\'s Bashundhara City shopping mall, with the band performing various songs from the album with collaborations from other notable artists. The album was said to have sold 5,000 copies three hours after launch and is considered to be Black\'s most critically acclaimed album and a landmark record for the rock music scene of Bangladesh.');

-- --------------------------------------------------------

--
-- Table structure for table `tracks`
--

CREATE TABLE `tracks` (
  `ID` int(11) NOT NULL,
  `track_title` varchar(100) DEFAULT NULL,
  `number` int(11) DEFAULT NULL,
  `video_url` varchar(200) DEFAULT NULL,
  `lyrics` varchar(2000) DEFAULT NULL,
  `albums_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tracks`
--

INSERT INTO `tracks` (`ID`, `track_title`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES
(1, 'Phootograph', 1, 'https://www.youtube.com/watch?v=nSDgHBxUbVQ', 'Loving can hurt\r\nLoving can hurt sometimes\r\nBut it\'s the only thing\r\nThat I know\r\nAnd when it gets hard\r\nYou know it can get hard sometimes\r\nIt is the only thing that makes us feel alive\r\nWe keep this love in a photograph\r\nWe make these memories for ourselves\r\nWhere our eyes are never closing\r\nHearts are never broken\r\nAnd time\'s forever frozen still\r\nSo you can keep me\r\nInside the pocket of your ripped jeans\r\nHoldin\' me closer \'til our eyes meet\r\nYou won\'t ever be alone\r\nWait for me to come home\r\nLoving can heal\r\nLoving can mend your soul\r\nAnd is the only thing\r\nThat I know, know\r\nI swear it will get easier\r\nRemember that with every piece of ya, mmm\r\nAnd it\'s the only thing we take with us when we die, mmm\r\nWe keep this love in a photograph\r\nWe make these memories for ourselves\r\nWhere our eyes are never closing\r\nHearts were never broken\r\nAnd time\'s forever frozen still\r\nSo you can keep me\r\nInside the pocket of your ripped jeans\r\nHoldin\' me closer \'til our eyes meet\r\nYou won\'t ever be alone\r\nAnd if you hurt me\r\nWell, that\'s okay, baby, only words bleed\r\nInside these pages you just hold me\r\nAnd I won\'t ever let you go\r\nWait for me to come home\r\nWait for me to come home\r\nWait for me to come home\r\nWait for me to come home\r\nOh, you can fit me\r\nInside the necklace you got when you were 16\r\nNext to your heartbeat where I should be\r\nKeep it deep within your soul\r\nAnd if you hurt me\r\nWell, that\'s okay, baby, only words bleed\r\nInside these pages you just hold me\r\nAnd I won\'t ever let you go\r\nWhen I\'m away\r\nI will remember how you kissed me\r\nUnder the lamppost back on 6th street\r\nHearing you whisper through the phone\r\nWait for me to come home', 4),
(3, 'Amar Prithibi', 1, 'https://www.youtube.com/watch?v=c8i1Qpcnsa8', 'The shadows will move\r\nI know the sun will come up\r\nUnder all the dead trees\r\nThe fire will burn\r\nRiver deep in the chest\r\nFog, fog\r\nSitting on a rock\r\nI see all this\r\nLooking at death\r\nI see the joy of life\r\nEverything is floating in the white sun\r\nBack to my feet again\r\nA song of sorrow\r\nEyes burned in eternal fire\r\nMy conscience burns under the sun\r\nLooking at death\r\nI see the joy of life\r\nEverything is floating in the white sun', 5),
(5, 'Come Together', 1, 'https://www.youtube.com/watch?v=45cYwDMibGo', 'Shoot me\r\nShoot me\r\nShoot me\r\nShoot me\r\nHere come old flat-top, he come grooving up slowly\r\nHe got juju eyeball, he one holy roller\r\nHe got hair down to his knee\r\nGot to be a joker, he just do what he please\r\nShoot me\r\nShoot me\r\nShoot me\r\nShoot me\r\nHe wear no shoeshine, he got toe-jam football\r\nHe got monkey finger, he shoot Coca-Cola\r\nHe say, \"I know you, you know me\"\r\nOne thing I can tell you is you got to be free\r\nCome together, right now\r\nOver me\r\nShoot me\r\nShoot me\r\nShoot me\r\nHe bag production, he got walrus gumboot\r\nHe got Ono sideboard, he one spinal cracker\r\nHe got feet down below his knee\r\nHold you in his armchair, you can feel his disease\r\nCome together, right now\r\nOver me\r\nShoot me\r\nRight!\r\nCome (come, come, come, come)\r\nHe roller-coaster, he got early warnin\'\r\nHe got muddy water, he one mojo filter\r\nHe say, \"One and one and one is three\"\r\nGot to be good-lookin\', \'cause he\'s so hard to see\r\nCome together, right now\r\nOver me\r\nShoot me\r\nShoot me\r\nShoot me\r\nOh\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nCome together, yeah\r\nAh!\r\nCome together, yeah\r\nCome together, yeah', 1),
(6, 'Haat Barao', 2, 'https://www.youtube.com/watch?v=AynmR0xlXsE', 'I won\'t wake up today I won\'t\r\n\r\ngo out of the house I won\'t see the sun today If I\r\ndon\'t laugh\r\nDon\'t cuddle Don\'t call me\r\nI\'m not going anywhere\r\n\r\nHold out your hand, pull\r\nme out now.\r\n\r\nSee,\r\nit\'s not dark outside, there\'s no noise\r\n, it\'s because you\r\n, to you, I\'m\r\nstill like a faded picture.\r\n\r\nHold out your hand, pull\r\nme out now.', 5),
(7, 'Amar Prithibi (Re-take)', 3, 'https://www.youtube.com/watch?v=c8i1Qpcnsa8', 'The shadows will move\r\nI know the sun will come up\r\nUnder all the dead trees\r\nThe fire will burn\r\nRiver deep in the chest\r\nFog, fog\r\nSitting on a rock\r\nI see all this\r\nLooking at death\r\nI see the joy of life\r\nEverything is floating in the white sun\r\nBack to my feet again\r\nA song of sorrow\r\nEyes burned in eternal fire\r\nMy conscience burns under the sun\r\nLooking at death\r\nI see the joy of life\r\nEverything is floating in the white sun', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `albums`
--
ALTER TABLE `albums`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tracks`
--
ALTER TABLE `tracks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_tracks_albums_idx` (`albums_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `albums`
--
ALTER TABLE `albums`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tracks`
--
ALTER TABLE `tracks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tracks`
--
ALTER TABLE `tracks`
  ADD CONSTRAINT `fk_tracks_albums` FOREIGN KEY (`albums_ID`) REFERENCES `albums` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
