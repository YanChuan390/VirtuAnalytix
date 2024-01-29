* code description: Find the central idea of the sentence and determine if the central idea is located in the sentence antecedent position.
* input: The raw HTML page of privacy policy document
* output: A list of all sentences in privacy policy document which central idea is located in the sentence antecedent position.
* detail: We use Spacy library to find the index position of the subject(nsubj) and predicate (ROOT) in each sentence, and then calculate their average position(I_c). We do not include the case in which the sentence length is less than 5. When the sentence length is greater than 5 and less than 20, we compare I_c with half the sentence length. When the sentence length is greater than 20 and less than 27, we compare the central index to one third of the sentence length, and we compare I_c to one third of the sentence length, and we compare the central index to a quarter of the sentence length when the sentence length is greater than 27.
 
