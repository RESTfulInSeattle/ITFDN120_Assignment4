Use the following code template to create a Binary search of an array of numeric element in your language of choice.

define function boolean IsInArray(startElement : number, endElement : number, elementToFind : number, elements : array of number)
{
    boolean found = false
    integer index = (endElement + startElement) / 2
    
    # Look in the middle
    if (elements[index] = elementToFind)
        {
        return true
        }

    # Go to the right
    if (elementToFind > elements[index])
        {
            return IsInArray(index+1, endElement, elementToFind, elements)
        }

    # Go to the left
     if (elementToFind < elements[index])
        {
            return IsInArray(startElement, index - 1, elementToFind, elements)
        }

    return false;
}

define numbers = [2,8,22,44,56,65,72,101,208,452,801]

Print IsInArray(0, numbers.Count - 1, 22, numbers)