/*
 Navicat MySQL Data Transfer

 Source Server         : my46321
 Source Server Type    : MySQL
 Source Server Version : 50720
 Source Host           : localhost:3306
 Source Schema         : bookstore

 Target Server Type    : MySQL
 Target Server Version : 50720
 File Encoding         : 65001

 Date: 14/01/2018 01:14:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for bookimages
-- ----------------------------
DROP TABLE IF EXISTS `bookimages`;
CREATE TABLE `bookimages`  (
  `ibook_id` int(11) NOT NULL,
  `iname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `iextension` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`ibook_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of bookimages
-- ----------------------------
INSERT INTO `bookimages` VALUES (1, '1', '.jpg');
INSERT INTO `bookimages` VALUES (2, '2', '.jpg');
INSERT INTO `bookimages` VALUES (3, '3', '.jpg');
INSERT INTO `bookimages` VALUES (4, '4', '.jpg');

-- ----------------------------
-- Table structure for books
-- ----------------------------
DROP TABLE IF EXISTS `books`;
CREATE TABLE `books`  (
  `ISBN` int(11) NULL DEFAULT NULL,
  `bname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `bauthor_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `bprice` double(10, 2) NULL DEFAULT NULL,
  `bstock` int(11) NULL DEFAULT NULL,
  `bstoryline` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `btype` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of books
-- ----------------------------
INSERT INTO `books` VALUES (1, '西游记', '吴承恩', 20.00, 1000, '西天取经', '冒险小说');
INSERT INTO `books` VALUES (2, '红楼梦', '曹雪芹', 30.00, 1000, '石头记，一个男人和一群女人', '文学小说');
INSERT INTO `books` VALUES (3, '三国演义', '罗贯中', 25.00, 1000, '记录三国历史', '历史小说');
INSERT INTO `books` VALUES (4, '水浒传', '施耐庵', 20.00, 1000, '官逼民反的故事', '社会小说');

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `oNO` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ouser_id` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `oadress` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `obook_id` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`oNO`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `uid` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `uemail` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `username` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `uname` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `utype` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `ucash` double(20, 0) NULL DEFAULT NULL,
  PRIMARY KEY (`uid`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO `userinfo` VALUES ('1', 'm13260933789@163.com', '123', '123', '孟越', 'user', 0);
INSERT INTO `userinfo` VALUES ('2', '1234', '12', '12', '孟越', '', 0);

SET FOREIGN_KEY_CHECKS = 1;
