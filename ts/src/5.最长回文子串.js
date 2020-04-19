/*
 * @lc app=leetcode.cn id=5 lang=javascript
 *
 * [5] 最长回文子串
 */

// @lc code=start

/**
 *
 * @param {string} s
 */
function isPalindrome(s) {
  for (let i = 0; i < Math.floor(s.length / 2); i++) {
    if (s[i] === s[s.length - 1 - i]) {
      continue;
    } else {
      return false;
    }
  }
  return true;
}
/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function (s) {
  let res = "";
  for (let i = 0; i < s.length; i++) {
    for (let j = 0; j < s.length; j++) {
      const str = s.substring(i, j + 1);
      if (isPalindrome(str) && str.length > res.length) {
        res = str;
      }
    }
  }
  return res;
};

// @lc code=end

//console.log(isPalindrome('a'));
longestPalindrome("babad");
