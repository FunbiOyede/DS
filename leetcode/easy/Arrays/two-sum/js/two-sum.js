
let numbers = [2,3,5,4,5,2];
let tar = 10;

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

function twoSum(nums, target){
   
    let indicesObject = {};

    for (let index = 0; index < nums.length; index++) {
        let remainder = target - nums[index]
        //check the key in the object
            if(indicesObject[remainder] !== undefined){
                //return matched key from object and current index
                return [indicesObject[remainder],index]
            }else{
                //add index as a value to the object, with the numbers in the array as a key
                indicesObject[nums[index]] = index
            }
        
    }
}


twoSum(numbers,tar);