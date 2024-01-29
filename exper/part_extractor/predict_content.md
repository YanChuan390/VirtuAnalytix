* code description: Categorize the contents of the privacy policy.
* input: Web page of privacy policy (html)
* output: A list of components in privacy policy containing 0 and 1 (0 means do not include component, 1 means include component)
* details: First get all the subtitles in the privacy policy by using ```find_subtitle.py```, then use ```bys_classifier.pkl``` and ```bys_tf.pkl``` in ```pre_title``` function to categorize these subtitles, and finally get a component list containing 0 and 1, where 0 means that the privacy policy does not contain this component, and 1 means that the privacy policy contains this component. 
