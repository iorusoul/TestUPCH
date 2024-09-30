--
-- PostgreSQL database dump
--

-- Dumped from database version 13.14
-- Dumped by pg_dump version 16.4

-- Started on 2024-09-29 19:30:33

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 5 (class 2615 OID 2200)
-- Name: public; Type: SCHEMA; Schema: -; Owner: postgres
--

-- *not* creating schema, since initdb creates it


ALTER SCHEMA public OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 201 (class 1259 OID 16423)
-- Name: auto; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.auto (
    id_auto integer NOT NULL,
    cantidad_plazas integer,
    tipo_caja_cambios integer,
    tipo_motor integer,
    cantidad_puertas integer,
    peso real,
    tipo_combustible integer,
    color character varying(50),
    marca character varying(50),
    modelo character varying(50),
    kilometraje integer,
    anio integer
);


ALTER TABLE public.auto OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 16421)
-- Name: auto_id_auto_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.auto_id_auto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.auto_id_auto_seq OWNER TO postgres;

--
-- TOC entry 3909 (class 0 OID 0)
-- Dependencies: 200
-- Name: auto_id_auto_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.auto_id_auto_seq OWNED BY public.auto.id_auto;


--
-- TOC entry 3768 (class 2604 OID 16426)
-- Name: auto id_auto; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.auto ALTER COLUMN id_auto SET DEFAULT nextval('public.auto_id_auto_seq'::regclass);


--
-- TOC entry 3902 (class 0 OID 16423)
-- Dependencies: 201
-- Data for Name: auto; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.auto (id_auto, cantidad_plazas, tipo_caja_cambios, tipo_motor, cantidad_puertas, peso, tipo_combustible, color, marca, modelo, kilometraje, anio) FROM stdin;
1	4	1	1	5	1500	1	Blanco	Toyota	Corolla	0	2024
2	2	2	1	3	2000	1	Verde	Kia	Rio	30000	2021
3	4	1	1	6	2500	1	Negro	Hyundai	h1	90000	2015
6	0	0	1	0	0	0	string	string	string	0	0
7	0	0	1	0	0	0	string	string	string	0	0
8	0	0	1	0	0	0	string	string	string	0	0
9	4	2	1	5	11000	1	rojo	volvo	f11	0	2024
13	4	2	1	5	11000	1	amarillo	volvo	f11	0	2024
11	4	2	1	5	11000	1	rojo	volvo	f11	0	2024
\.


--
-- TOC entry 3910 (class 0 OID 0)
-- Dependencies: 200
-- Name: auto_id_auto_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.auto_id_auto_seq', 13, true);


--
-- TOC entry 3770 (class 2606 OID 16428)
-- Name: auto pk_id_auto; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.auto
    ADD CONSTRAINT pk_id_auto PRIMARY KEY (id_auto);


--
-- TOC entry 3908 (class 0 OID 0)
-- Dependencies: 5
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2024-09-29 19:30:43

--
-- PostgreSQL database dump complete
--

