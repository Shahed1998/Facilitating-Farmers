const handleTranslation = (e) => {
  switch (e.target.value) {
    case 'en':
      e.target.value = 'bn-BD';
      e.target.textContent = 'Bengali';
      window.translateTo('bn-BD');
      break;
    case 'bn-BD':
      e.target.value = 'en';
      e.target.textContent = 'English';
      window.translateTo('en');
      break;
    default:
      e.target.value = 'en';
      e.target.textContent = 'English';
      window.translateTo('en');
  }
};

export default handleTranslation;
