import { NavLink } from 'react-router-dom';

const Navbar = () => {
  return (
    <nav className='navbar navbar-expand-lg bg-light'>
      <div className='container-fluid'>
        <NavLink to='home' className='navbar-brand'>
          <img
            src='harvest-farming.png'
            alt='logo'
            style={{ width: '15%' }}
          ></img>
        </NavLink>

        <button
          className='navbar-toggler'
          type='button'
          data-bs-toggle='collapse'
          data-bs-target='#navbarNav'
          aria-controls='navbarNav'
          aria-expanded='false'
          aria-label='Toggle navigation'
        >
          <span className='navbar-toggler-icon'></span>
        </button>
        <div className='collapse navbar-collapse' id='navbarNav'>
          <ul className='navbar-nav ms-auto'>
            <li className='nav-item p-2'>
              <a className='nav-link' aria-current='page' href='#'>
                কোর্স
              </a>
            </li>
            <li className='nav-item p-2'>
              <a className='nav-link' href='#'>
                বিশেষজ্ঞ
              </a>
            </li>
            <li className='nav-item p-2'>
              <a className='nav-link' href='#'>
                প্রশ্নোত্তর
              </a>
            </li>
            <li className='nav-item p-2'>
              <a className='nav-link'>ক্রয়/বিক্রয়</a>
            </li>
            <li className='nav-item p-2'>
              <a className=' btn btn-secondary'>English</a>
            </li>
            <li className='nav-item p-2'>
              <a className=' btn btn-secondary'>সাইন ইন করুন</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
