import { Routes, Route } from 'react-router-dom';
import Home from './components/Home/Index';
import Navbar from './components/Navbar/Index';
import i18next from 'i18next';

const App = () => {
  window.translateTo = (lang) => {
    i18next.changeLanguage(lang);
  };

  return (
    <>
      <Navbar></Navbar>
      <Routes>
        <Route path='/' element={<Home />} />
      </Routes>
    </>
  );
};

export default App;
