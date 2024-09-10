import { Navbar, Nav, Container } from 'react-bootstrap';
import { FaSignInAlt, FaSignOutAlt } from 'react-icons/fa';

const Header = () => {
    return (
        <header>
            <Navbar bg='dark' variant='dark' expand='lg' collapseOnSelect>
                <Container>
                    <Navbar.Brand href='/'>Cashly</Navbar.Brand>
                    <Navbar.Toggle aria-controls='basic-navbar-nav' />
                    <Navbar.Collapse id='basic-navbar-nav'>
                        <nav className='ms-auto'>
                            <nav.Link href='/login'>
                                <FaSignInAlt /> Sign In
                            </nav.Link><nav.Link href='/signup'>
                                <FaSignOutAlt /> Sign Up
                            </nav.Link>
                        </nav>
                    </Navbar.Collapse>
                </Container>
            </Navbar>
        </header>  
    );
}

export default Header;