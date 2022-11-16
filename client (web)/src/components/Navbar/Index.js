import { NavLink, Link } from 'react-router-dom';

const Navbar = () => {
  return (
    <nav className='navbar navbar-expand-lg bg-light'>
      <div className='container-fluid'>
        <NavLink to='/' className='navbar-brand'>
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
              <NavLink to={'/courses'} className='nav-link'>
                কোর্স
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/specialists'} className='nav-link'>
                বিশেষজ্ঞ
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/question-answers'} className='nav-link'>
                প্রশ্নোত্তর
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <NavLink to={'/buy-sell'} className='nav-link'>
                ক্রয়/বিক্রয়
              </NavLink>
            </li>
            <li className='nav-item p-2'>
              <Link className=' btn btn-secondary'>English</Link>
            </li>
            <li className='nav-item p-2'>
              <Link className=' btn btn-secondary'>সাইন ইন করুন</Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
